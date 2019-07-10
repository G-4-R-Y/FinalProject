using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Model.Models;
using Service.Services;

namespace View
{
    public partial class FormCashflow : Form
    {
        private ServiceGeneric<Cashflow>    cashflowService    = new ServiceGeneric<Cashflow>();
        private ServiceGeneric<Earning>     earningService     = new ServiceGeneric<Earning>();
        private ServiceGeneric<Payment>     paymentService     = new ServiceGeneric<Payment>();
        private ServiceGeneric<SaleProduct> saleProductService = new ServiceGeneric<SaleProduct>();
        private ServiceGeneric<Product>     productService     = new ServiceGeneric<Product>();
        private ServiceGeneric<Storage>     storageService     = new ServiceGeneric<Storage>();
        private ServiceGeneric<Sale>        saleService        = new ServiceGeneric<Sale>();


        public FormCashflow()
        {
            InitializeComponent();
            refreshDataGridViewCashflow();
            updateTotal();
        }

        private void refreshDataGridViewCashflow()
        {
            dgvCashflow.DataSource = null;
            List<Cashflow> cashflows = null;

            if (cashflowService.ShowAll() != null)
            {
                cashflows = cashflowService.ShowAll().ToList();
                foreach (var cashflow in cashflows)
                {
                    if (cashflow.EarningId != null)
                    {
                        cashflow.Earning = earningService.GetById(cashflow.EarningId);
                    }
                    else if (cashflow.PaymentId != null)
                    {
                        cashflow.Payment = paymentService.GetById(cashflow.PaymentId);
                    }
                }
            }
            dgvCashflow.DataSource = cashflows;
        }

        private void refreshDataGridViewCashflow(Earning earning)
        {
            dgvCashflow.DataSource = null;
            List<Cashflow> cashflows = null;
            if (cashflowService.ShowAll().Where(c => c.EarningId == earning.EarningId) != null)
            {
                cashflows = cashflowService.ShowAll().Where(c => c.EarningId == earning.EarningId).ToList();
                foreach (var cashflow in cashflows)
                {
                    if (cashflow.EarningId != null)
                    {
                        cashflow.Earning = earningService.GetById(cashflow.EarningId);
                    }
                    else if (cashflow.PaymentId != null)
                    {
                        cashflow.Payment = paymentService.GetById(cashflow.PaymentId);
                    }
                }
            }
            dgvCashflow.DataSource = cashflows;
        }

        private void refreshDataGridViewCashflow(Payment payment)
        {
            dgvCashflow.DataSource = null;
            List<Cashflow> cashflows = null;
            if (cashflowService.ShowAll().Where(c => c.PaymentId == payment.PaymentId) != null)
            {
                cashflows = cashflowService.ShowAll().Where(c => c.PaymentId == payment.PaymentId).ToList();
                foreach (var cashflow in cashflows)
                {
                    if (cashflow.EarningId != null)
                    {
                        cashflow.Earning = earningService.GetById(cashflow.EarningId);
                    }
                    else if (cashflow.PaymentId != null)
                    {
                        cashflow.Payment = paymentService.GetById(cashflow.PaymentId);
                    }
                }
            }
            dgvCashflow.DataSource = cashflows;
        }

        private void refreshDataGridViewEarningPayment()
        {
            dgvEarningPayment.DataSource = null;
            List<Earning> earnings = null;
            if (earningService.ShowAll() != null)
            {
                earnings = earningService.ShowAll().ToList();
            }
            List<Payment> payments = null;
            if (paymentService.ShowAll() != null)
            {
                payments = paymentService.ShowAll().ToList();
            }

            List<EarnPay> EarningPayment = new List<EarnPay>();


            foreach (var earning in earnings)
            {
                earning.Sale = saleService.GetById(earning.SaleId);
                EarningPayment.Add(earning);
            }

            foreach (var payment in payments)
            {
                payment.Storage = storageService.GetById(payment.StorageId);
                EarningPayment.Add(payment);
            }

            dgvEarningPayment.DataSource = EarningPayment;
        }

        private void refreshDataGridViewEarningPayment(Earning earning)
        {
            dgvEarningPayment.DataSource = null;
            List<Earning> earnings = null;

            if (earningService.ShowAll().Where(e => e.EarningId == earning.EarningId) != null)
            {
                earnings = earningService.ShowAll().Where(e => e.EarningId == earning.EarningId).ToList();
                foreach (var earn in earnings)
                {
                    earn.Sale = saleService.GetById(earn.SaleId);
                }
            }
            dgvEarningPayment.DataSource = earnings;
        }

        private void refreshDataGridViewEarningPayment(Payment payment)
        {
            dgvEarningPayment.DataSource = null;
            List<Payment> payments = null;

            if (paymentService.ShowAll().Where(p => p.PaymentId == payment.PaymentId) != null)
            {
                payments = paymentService.ShowAll().Where(p => p.PaymentId == payment.PaymentId).ToList();
                foreach (var pay in payments)
                {
                    pay.Storage = storageService.GetById(pay.StorageId);
                }
            }
            dgvEarningPayment.DataSource = payments;
        }

        private void refreshDataGridViewSaleStorage(Earning earning)
        {
            dgvSaleStorage.DataSource = null;
            if (saleService.ShowAll().Where(s => s.SaleId == earning.SaleId) != null)
            {
                dgvSaleStorage.DataSource = saleService.ShowAll().Where(s => s.SaleId == earning.SaleId).ToList();
            }
        }

        private void refreshDataGridViewSaleStorage(Payment payment)
        {
            dgvSaleStorage.DataSource = null;
            List<Storage> storages = null;
            if (storageService.ShowAll().Where(s => s.StorageId == payment.StorageId) != null)
            {
                storages = storageService.ShowAll().Where(s => s.StorageId == payment.StorageId).ToList();
                foreach (var storage in storages)
                {
                    storage.Product = productService.GetById(storage.ProductId);
                }
            }
            dgvSaleStorage.DataSource = storages;
        }

        private void refreshDataGridViewProductExam(Sale sale)
        {
            dgvProductExam.DataSource = null;
            List<SaleProduct> saleProducts = null;
            if (saleProductService.ShowAll().Where(sp => sp.SaleId == sale.SaleId) != null)
            {
                saleProducts = saleProductService.ShowAll().Where(sp => sp.SaleId == sale.SaleId).ToList();
                foreach (var saleProduct in saleProducts)
                {
                    saleProduct.Product = productService.GetById(saleProduct.ProductId);
                }
            }
            dgvProductExam.DataSource = saleProducts;
        }

        private void refreshDataGridViewProductExam(Storage storage)
        {
            dgvProductExam.DataSource = null;
            if (productService.ShowAll().Where(p => p.ProductId == storage.ProductId) != null)
            {
                dgvProductExam.DataSource = productService.ShowAll().Where(p => p.ProductId == storage.ProductId).ToList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 

        }

        private void txtAllTime_Click(object sender, EventArgs e)
        {

        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {

        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            refreshDataGridViewCashflow();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            dgvCashflow.DataSource = null;
            dgvCashflow.DataSource = cashflowService.ShowAll().Where(c => c.PaymentId != null).ToList();
        }

        private void btnEarning_Click(object sender, EventArgs e)
        {
            dgvCashflow.DataSource = null;
            dgvCashflow.DataSource = cashflowService.ShowAll().Where(c => c.EarningId != null).ToList();
        }

        //carrega os dados do cashflow selecionado nos controles
        private void loadCashflowData(Cashflow cashflow)
        {
            txtId.Text = Convert.ToString(cashflow.CashflowId);
        }

        //obtém o CashflowId do cashflow selecionado no dgv
        private int getCashflowIdDgv(int rowIndex)
        {
            return Convert.ToInt32(dgvCashflow.Rows[rowIndex].Cells[0].Value);
        }

        private void dgvCashflow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cashflowId = getCashflowIdDgv(e.RowIndex);
                if (cashflowId.Equals(null) || !(cashflowId > 0))
                {
                    return;
                }
                var cashflow = cashflowService.GetById(getCashflowIdDgv(e.RowIndex));
                loadCashflowData(cashflow);

                if (cashflow.EarningId == null)
                {
                    Payment payment = paymentService.GetById(Convert.ToInt64(cashflow.PaymentId));
                    refreshDataGridViewEarningPayment(payment);

                    Storage storage = storageService.GetById(Convert.ToInt64(payment.StorageId));
                    refreshDataGridViewSaleStorage(payment);

                    refreshDataGridViewProductExam(storage);
                }

                else if (cashflow.PaymentId == null)
                {
                    Earning earning = earningService.GetById(Convert.ToInt64(cashflow.EarningId));
                    refreshDataGridViewEarningPayment(earning);

                    Sale sale = saleService.GetById(Convert.ToInt64(earning.SaleId));
                    refreshDataGridViewSaleStorage(earning);

                    refreshDataGridViewProductExam(sale);
                }
            }
        }

        private void dgvCashflow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            dgvCashflow.DataSource = null;
            dgvCashflow.DataSource = cashflowService.ShowAll().Where(c => c.Paid == true).ToList();
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            dgvCashflow.DataSource = null;
            dgvCashflow.DataSource = cashflowService.ShowAll().Where(c => c.Paid == false).ToList();
        }

        private void resetForm()
        {
            txtId.Clear();
            refreshDataGridViewCashflow();
            dgvEarningPayment.DataSource = null;
            dgvSaleStorage.DataSource = null;
            dgvProductExam.DataSource = null;
            updateTotal();
        }

        private void updateTotal()
        {
            List<Cashflow> cashflows = cashflowService.ShowAll().Where(c => c.Paid == true && c.Canceled == false).ToList();
            double total = 0;
            foreach (Cashflow cashflow in cashflows)
            {
                if (cashflow.EarningId != null)
                {
                    Earning earning = earningService.GetById(cashflow.EarningId);
                    total += earning.Value;
                }
                else
                {
                    Payment payment = paymentService.GetById(cashflow.PaymentId);
                    total -= payment.Value;
                }
            }
            txtTotal.Text = Convert.ToString(total);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("A caixa de Id não deve estar vazia, selecione um dono antes de alterar.");
                return;
            }
            else
            {
                Cashflow cashflow = cashflowService.GetById(Convert.ToInt64(txtId.Text));

                cashflow.Paid = true;
                
                if (cashflow.Earning != null)
                {
                    cashflow.Earning.Paid = true;
                    earningService.Alter(cashflow.Earning);
                }
                else if (cashflow.Payment != null)
                {
                    cashflow.Payment.Paid = true;
                    paymentService.Alter(cashflow.Payment);
                }

                cashflowService.Alter(cashflow);

                refreshDataGridViewCashflow();
                resetForm();
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                btnPay.Enabled = false;
            }
            else
            {
                btnPay.Enabled = true;
            }
        }
    }
}
