using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Models;
using Service.Services;

namespace View
{
    public partial class FormStorage : Form
    {
        private ServiceGeneric<Product>  productService  = new ServiceGeneric<Product>();
        private ServiceGeneric<Storage>  storageService  = new ServiceGeneric<Storage>();
        private ServiceGeneric<Payment>  paymentService  = new ServiceGeneric<Payment>();
        private ServiceGeneric<Cashflow> cashflowService = new ServiceGeneric<Cashflow>();

        public FormStorage()
        {
            InitializeComponent();
            populateProductCombobox();
            refreshDataGridView();
        }

        private void populateProductCombobox()
        {
            List<Product> products = productService.ShowAll().OrderBy(p => p.Name).ToList<Product>();
            products.Insert(0, new Product("Nome", 00) { ProductId = -1 });

            cbProduct.DisplayMember = "Name";
            cbProduct.ValueMember = "ProductId";
            cbProduct.DataSource = products;
        }

        private bool allFullfilled()
        {
            if (Convert.ToInt64(cbProduct.SelectedValue) == -1)
            {
                MessageBox.Show("É necessário selecionar produto para o lote.");
                cbProduct.BackColor = Color.LightSalmon;
                txtLot.BackColor = DefaultBackColor;
                txtQuantity.BackColor = DefaultBackColor;
                txtCost.BackColor = DefaultBackColor;
                return false;
            }
            else if (txtLot.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo lote deve ser preenchido.");
                txtLot.BackColor = Color.LightSalmon;
                txtQuantity.BackColor = DefaultBackColor;
                txtCost.BackColor = DefaultBackColor;
                cbProduct.BackColor = DefaultBackColor;
                return false;
            }
            else if (txtLot.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo quantidade deve ser preenchido.");
                txtQuantity.BackColor = Color.LightSalmon;
                txtLot.BackColor = DefaultBackColor;
                txtCost.BackColor = DefaultBackColor;
                cbProduct.BackColor = DefaultBackColor;
                return false;
            }
            else if (txtCost.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo custo deve ser preenchido.");
                txtCost.BackColor = Color.LightSalmon;
                txtLot.BackColor = DefaultBackColor;
                txtQuantity.BackColor = DefaultBackColor;
                cbProduct.BackColor = DefaultBackColor;
                return false;
            }
            else
            {
                txtLot.BackColor = DefaultBackColor;
                txtQuantity.BackColor = DefaultBackColor;
                txtCost.BackColor = DefaultBackColor;
                cbProduct.BackColor = DefaultBackColor;
                return true;
            }
        }

        //refresh inicial (Mostra todos os lotes)
        private void refreshDataGridView()
        {
            dgvStorage.DataSource = null;
            IList<Storage> storage = null;
            if (storageService.ShowAll() != null)
            {
                storage = storageService.ShowAll();
                foreach (Storage lot in storage)
                {
                    lot.Product = productService.GetById(Convert.ToInt64(lot.ProductId));
                }
            }
            dgvStorage.DataSource = storage;
        }

        private void refreshDataGridView(Product product)
        {
            dgvStorage.DataSource = null;
            List<Storage> storage = null;
            if (storageService.ShowAll().Where(s => s.ProductId == product.ProductId) != null)
            {
                storage = storageService.ShowAll().Where(s => s.ProductId == product.ProductId).ToList();
                foreach (Storage lot in storage)
                {
                    lot.Product = productService.GetById(lot.ProductId);
                }
            }
            dgvStorage.DataSource = storage;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormStorage_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void resetForm()
        {
            txtId.Clear();
            cbProduct.SelectedIndex = 0;
            dtPurchase.Value = DateTime.Today;
            dtValidity.Value = DateTime.Today;
            dtExpiration.Value = DateTime.Today;
            txtLot.ResetText();
            txtQuantity.ResetText();
            txtCost.Clear();

            refreshDataGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt64(cbProduct.SelectedValue) > 0)
            {
                Product product = productService.GetById(Convert.ToInt64(cbProduct.SelectedValue));

                refreshDataGridView(product);
            }
        }

        //carrega os dados do lote selecionado nos controles
        private void loadStorageData(Storage storage)
        {
            Product product = productService.GetById(storage.ProductId.Value);

            cbProduct.SelectedValue = 0;
            cbProduct.SelectedValue = product.ProductId;

            txtId.Text = $"{ storage.StorageId}";
            dtPurchase.Value = storage.Date;
            dtValidity.Value = storage.Validity;
            dtExpiration.Value = storage.Expiration;
            txtLot.Text = Convert.ToString(storage.Lot);
            txtQuantity.Text = Convert.ToString(storage.Quantity);
            txtCost.Text = Convert.ToString(storage.Cost);
        }

        //obtém o StorageId do lota selecionado no dgv
        private int getStorageIdDgv(int rowIndex)
        {
            return Convert.ToInt32(dgvStorage.Rows[rowIndex].Cells[0].Value);
        }

        private void dgvStorage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var storageId = getStorageIdDgv(e.RowIndex);
                if (storageId.Equals(null) || !(storageId > 0))
                {
                    return;
                }
                loadStorageData(storageService.GetById(getStorageIdDgv(e.RowIndex)));
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(""))
            {
                MessageBox.Show("A caixa de Id deve estar vazia, aperte em resetar para limpa-la.");
                return;
            }
            else if (allFullfilled())
            {
                var productId = Convert.ToInt64(cbProduct.SelectedValue);
                Product Product = (Product)productService.GetById(productId);
                Storage newStorage = new Storage(dtValidity.Value, dtExpiration.Value,Convert.ToDouble(txtCost.Text), Convert.ToInt32(txtQuantity.Text), Convert.ToInt32(txtLot.Text), dtPurchase.Value)
                {
                    ProductId = productId
                };

                storageService.Insert(newStorage);

                Payment newPayment = new Payment(newStorage.Total, dtPurchase.Value, dtExpiration.Value, newStorage.StorageId);

                paymentService.Insert(newPayment);

                Cashflow newCashflow = new Cashflow()
                {
                    PaymentId = newPayment.PaymentId,
                    EarningId = null
                };

                cashflowService.Insert(newCashflow);

                resetForm();
                
                refreshDataGridView();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("É preciso selecionar uma consulta para remove-la da base de dados.");
                return;
            }
            else if (allFullfilled())
            {
                storageService.Remove(Convert.ToInt64(txtId.Text));
                resetForm();
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("A caixa de Id não deve estar vazia, selecione um registro de compra de lote para cancelar.");
                return;
            }

            else if (allFullfilled())
            {
                var productId = Convert.ToInt64(cbProduct.SelectedValue);
                Product product = (Product)productService.GetById(productId);
                Storage canceledStorage = new Storage(dtValidity.Value, dtExpiration.Value,Convert.ToDouble(txtCost.Text), Convert.ToInt32(txtQuantity.Text), Convert.ToInt32(txtLot.Text), dtPurchase.Value)
                {
                    ProductId = productId,
                    StorageId = Convert.ToInt64(txtId.Text)
                };

                canceledStorage.Canceled = true;

                storageService.Alter(canceledStorage);

                List<Cashflow> canceledCashflows = new List<Cashflow>();
                List<Payment>  canceledPayments  = paymentService.ShowAll().Where(p => p.StorageId == canceledStorage.StorageId).ToList();

                foreach (var canceledPayment in canceledPayments)
                {
                    canceledPayment.Paid = false;
                    canceledPayment.Canceled = true;
                    paymentService.Alter(canceledPayment);
                    List<Cashflow> canceledCashflowsAux = cashflowService.ShowAll().Where(c => c.PaymentId == canceledPayment.PaymentId).ToList();
                    foreach (var canceledCashflow in canceledCashflowsAux)
                    {
                        canceledCashflows.Add(canceledCashflow);
                    }
                }
                foreach (var canceledCashflow in canceledCashflows)
                {
                    canceledCashflow.Paid = false;
                    canceledCashflow.Canceled = true;
                }

                refreshDataGridView();

                resetForm();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                btnAlter.Enabled = false;
            }
            else
            {
                btnAlter.Enabled = true;
            }
        }

        private void dgvStorage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
