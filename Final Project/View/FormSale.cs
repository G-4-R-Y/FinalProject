using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Services;
using Model.Models;

namespace View
{
    public partial class FormSale : Form
    {
        private SaleService                 saleService        = new SaleService();
        private ServiceGeneric<Exam>        examService        = new ServiceGeneric<Exam>();
        private ServiceGeneric<Product>     productService     = new ServiceGeneric<Product>();
        private ServiceGeneric<Earning>     earningService     = new ServiceGeneric<Earning>();
        private ServiceGeneric<SaleProduct> saleProductService = new ServiceGeneric<SaleProduct>();
        private ServiceGeneric<Cashflow>    cashflowService    = new ServiceGeneric<Cashflow>();
        private ServiceGeneric<Storage> storageService = new ServiceGeneric<Storage>();

        public FormSale()
        {
            InitializeComponent();
            refreshDataGridView();
            populateProductCombobox();
            populateExamCombobox();
            resetForm();
        }

        private void populateProductCombobox()
        {
            List<Product> products = productService.ShowAll().OrderBy(p => p.Name).ToList<Product>();
            products.Insert(0, new Product("Nome", 00) { ProductId = -1 });

            cbProduct.DisplayMember = "Name";
            cbProduct.ValueMember = "ProductId";
            cbProduct.DataSource = products;
        }

        private void populateExamCombobox()
        {
            List<Exam> exams = examService.ShowAll().OrderBy(e => e.Name).ToList<Exam>();
            exams.Insert(0, new Exam("Nome", 00 ) { ExamId = -1 });

            cbExam.DisplayMember = "Name";
            cbExam.ValueMember = "ExamId";
            cbExam.DataSource = exams;
        }

        private void refreshDataGridView()
        {
            dgvSale.DataSource = null;
            List<Sale> sales = null;
            if (saleService.ShowAll() != null)
            {
                sales = saleService.ShowAll().ToList();
                foreach (var sale in sales)
                {
                    sale.SaleProduct = saleProductService.ShowAll().Where(sp => sp.SaleId == sale.SaleId).ToList();
                }
            }
            dgvSale.DataSource = sales;
        }

        private void refreshDataGridViewProducts()
        {
            dgvProduct.DataSource = null;
        }

        private void refreshDataGridViewProducts(Sale sale)
        {
            dgvProduct.DataSource = null;
            if (saleProductService.ShowAll().Where(sp => sp.SaleId == sale.SaleId) != null)
            {
                dgvProduct.DataSource = saleProductService.ShowAll().Where(sp => sp.SaleId == sale.SaleId).ToList();
            }
        }

        private bool allFullfilledProduct()
        {
            if (Convert.ToInt64(cbProduct.SelectedValue) == -1 && Convert.ToInt64(cbExam.SelectedValue) == -1)
            {
                MessageBox.Show("É necessário escolher um produto ou um exame para adicionar à venda.");
                cbProduct.BackColor = Color.LightSalmon;
                cbExam.BackColor = Color.LightSalmon;
                txtQnt.BackColor = DefaultBackColor;
                return false;
            }
            else if (Convert.ToInt64(cbProduct.SelectedValue) != -1 && Convert.ToInt64(cbExam.SelectedValue) != -1)
            {
                MessageBox.Show("É necessário um produto OU um exame para adicionar a venda.");
                cbProduct.BackColor = Color.LightSalmon;
                cbExam.BackColor = Color.LightSalmon;
                txtQnt.BackColor = DefaultBackColor;
                return false;
            }
            else if (!txtQnt.MaskCompleted)
            {
                MessageBox.Show("É necessário inserir uma quantidade entre 0 e 999999.");
                txtQnt.BackColor = Color.LightSalmon;
                cbProduct.BackColor = DefaultBackColor;
                cbExam.BackColor = DefaultBackColor;
                return false;
            }
            
            cbProduct.BackColor = DefaultBackColor;
            cbExam.BackColor = DefaultBackColor;
            txtQnt.BackColor = DefaultBackColor;
            return true;
        }

        private void resetFormProduct()
        {
            cbProduct.SelectedIndex = 0;
            cbExam.SelectedIndex = 0;
            txtQnt.Clear();

            if (txtId.Text.Equals(String.Empty))
            {
                refreshDataGridViewProducts();
            }
            else
            {
                Sale sale = saleService.GetById(Convert.ToInt64(txtId.Text));
                refreshDataGridViewProducts(sale);
            }
        }

        private void resetForm()
        {
            dtSale.Value = DateTime.Today;
            dtExpiration.Value = DateTime.Today;
            refreshDataGridView();
            btnAddProduct.Enabled = false;
            btnResetProduct.Enabled = false;
            resetFormProduct();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo id deve estar vazio para fazer um novo registro de venda, resete o formulário para limpar os campos e tente novamente.");
            }
            else
            {
                var newSale = new Sale(dtSale.Value, dtExpiration.Value);
                newSale.ExpirationDate = dtExpiration.Value;
                saleService.Insert(newSale);

                var newEarning = new Earning(0, newSale.Date, newSale.ExpirationDate, newSale.SaleId);
                earningService.Insert(newEarning);

                var newCashflow = new Cashflow()
                {
                    EarningId = newEarning.EarningId,
                    PaymentId = null
                };

                cashflowService.Insert(newCashflow);

                resetForm();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnAlter_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("A caixa de Id não deve estar vazia, selecione um registro de compra de lote para cancelar.");
                return;
            }

            else
            {
                var canceledSale = new Sale(dtSale.Value, dtExpiration.Value)
                {
                    SaleId = Convert.ToInt64(txtId.Text)
                };

                canceledSale.Canceled = true;

                List<SaleProduct> saleProducts = saleProductService.ShowAll().Where(sp => sp.SaleId == canceledSale.SaleId).ToList();

                foreach (SaleProduct saleProduct in saleProducts)
                {
                    Storage storage = storageService.ShowAll().Where(s => s.ProductId == saleProduct.ProductId && s.Lot == saleProduct.Lot).FirstOrDefault();
                    storage.Quantity += saleProduct.Quantity;
                    storageService.Alter(storage);
                }

                saleService.Alter(canceledSale);

                List<Cashflow> canceledCashflows = new List<Cashflow>();
                List<Earning>  canceledEarnings  = earningService.ShowAll().Where(earning => earning.SaleId == canceledSale.SaleId).ToList();

                foreach (var canceledEarning in canceledEarnings)
                {
                    canceledEarning.Paid = false;
                    canceledEarning.Canceled = true;
                    earningService.Alter(canceledEarning);

                    var canceledCashflow = cashflowService.ShowAll().Where(c => c.EarningId == canceledEarning.EarningId).FirstOrDefault();
                    canceledCashflows.Add(canceledCashflow);
                }

                foreach (var canceledCashflow in canceledCashflows)
                {
                    canceledCashflow.Paid = false;
                    canceledCashflow.Canceled = true;
                    cashflowService.Alter(canceledCashflow);
                }

                refreshDataGridView();

                resetForm();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                btnCancel.Enabled = false;
                btnAddProduct.Enabled = false;
                btnResetProduct.Enabled = false;
            }
            else
            {
                btnCancel.Enabled = true;
                btnAddProduct.Enabled = true;
                btnResetProduct.Enabled = true;
            }
        }

        private void dtSale_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormSale_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                MessageBox.Show("É necessário selecionar uma consulta já marcada para prescrever um remédio.");
                return;
            }
            if (allFullfilledProduct())
            {
                Earning earning;
                SaleProduct newEntry;

                if (Convert.ToInt64(cbProduct.SelectedValue) != -1)
                {
                    /*SaleProduct isExistentSaleProduct = saleProductService.ShowAll().Where(sp => sp.SaleId == Convert.ToInt64(txtId.Text) && sp.ProductId == Convert.ToInt64(cbProduct.SelectedValue)).FirstOrDefault();
                    if (isExistentSaleProduct != null)
                    {
                        MessageBox.Show("O produto selecionado já está registrado, registre outra compra para comprar uma quantidade diferente.");
                        return;
                    }
                    else
                    {*/
                    Product product = productService.GetById(Convert.ToInt64(cbProduct.SelectedValue));

                    newEntry = new SaleProduct(Convert.ToInt64(txtId.Text), Convert.ToInt32(txtQnt.Text))
                    {
                        ProductId = product.ProductId,
                        ExamId = null
                    };

                    int quantityOriginal = Convert.ToInt32(txtQnt.Text);
                    int quantity = quantityOriginal;
                    Storage storage = storageService.ShowAll().Where(s => s.ProductId == product.ProductId && s.Quantity > 0).FirstOrDefault();
                    newEntry.Lot = storage.Lot;
                    if (storage.Quantity < quantity)
                    {
                        MessageBox.Show($"Não há estoque suficiente de um único lote para finalizar compra, faltaram {quantity} itens. Compre em dois pedidos para comprar de lotes diferentes.");
                        return;
                    }
                    else
                    {
                        storage.Quantity -= quantity;
                        storageService.Alter(storage);
                    }
                    earning = earningService.ShowAll().Where(earn => earn.SaleId == Convert.ToInt64(txtId.Text)).FirstOrDefault();

                    earning.Value += product.Cost * newEntry.Quantity;
                    //}
                }

                else
                {
                    /*SaleProduct isExistentSaleProduct = saleProductService.ShowAll().Where(sp => sp.SaleId == Convert.ToInt64(txtId.Text) && sp.ProductId == Convert.ToInt64(cbProduct.SelectedValue)).FirstOrDefault();
                    if (isExistentSaleProduct != null)
                    {
                        MessageBox.Show("O exame selecionado já está registrado, registre outra compra para comprar uma quantidade diferente de exames.");
                        return;
                    }
                    else
                    {*/
                    Exam exam = examService.GetById(Convert.ToInt64(cbExam.SelectedValue));

                    newEntry = new SaleProduct(Convert.ToInt64(txtId.Text), Convert.ToInt32(txtQnt.Text))
                    {
                        ExamId = exam.ExamId,
                        ProductId = null
                    };

                    earning = earningService.ShowAll().Where(earn => earn.SaleId == Convert.ToInt64(txtId.Text)).FirstOrDefault();

                    earning.Value += exam.Cost * newEntry.Quantity;
                    //}
                }

                saleProductService.Insert(newEntry);

                earningService.Alter(earning);

                refreshDataGridViewProducts(saleService.GetById(Convert.ToInt64(txtId.Text)));
            }
        }

        //carrega os dados da venda selecionada nos controles
        private void loadSaleData(Sale sale)
        {
            resetForm();
            btnAddProduct.Enabled = true;
            btnResetProduct.Enabled = true;

            refreshDataGridViewProducts(sale);

            txtId.Text = $"{ sale.SaleId }";
            dtSale.Value = sale.Date;
            dtExpiration.Value = sale.ExpirationDate;
        }

        //obtém o SaleId da venda selecionada no dgv
        private int getSaleIdDgv(int rowIndex)
        {
            return Convert.ToInt32(dgvSale.Rows[rowIndex].Cells[0].Value);
        }

        private void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var saleId = getSaleIdDgv(e.RowIndex);
            if (saleId.Equals(null) || !(saleId > 0))
            {
                return;
            }
            if (e.RowIndex >= 0)
            {
                loadSaleData(saleService.GetById(getSaleIdDgv(e.RowIndex)));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetFormProduct();
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
