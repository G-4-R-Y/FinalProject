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
    public partial class FormDrug : Form
    {
        private ServiceGeneric<Product> drugService = new ServiceGeneric<Product>();

        public FormDrug()
        {
            InitializeComponent();
            refreshDataGridView();
        }

        private void refreshDataGridView()
        {
            dgvDrugs.DataSource = null;
            dgvDrugs.DataSource = drugService.ShowAll();
        }

        private bool allFullfilled()
        {
            if (txtName.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo nome deve ser preenchido.");
                txtName.BackColor = Color.LightSalmon;
                return false;
            }
            else if (!txtCost.MaskCompleted)
            {
                MessageBox.Show("O campo custo deve ser preenchido.");
                txtCost.BackColor = Color.LightSalmon;
                return false;
            }

            txtName.BackColor = DefaultBackColor;
            txtCost.BackColor = DefaultBackColor;
            
            return true;
        }

        private void FormPetDrug_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(String.Empty)) 
            {
                MessageBox.Show("O campo id deve estar vazio para fazer um novo registro, resete o formulário para limpar os campos e tente novamente.");
            }
            else if (allFullfilled())
            {
                drugService.Insert(new Product(txtName.Text, Convert.ToDouble(txtCost.Text)));
                resetForm();
                refreshDataGridView();
            }
        }

        private void resetForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtCost.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo id deve estar preenchido para remover um registro, selecione um remédio e tente novamente.");
            }
            else if (allFullfilled())
            {
                drugService.Remove(Convert.ToInt64(txtId.Text));
                resetForm();
                refreshDataGridView();
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("A caixa de Id não deve estar vazia, selecione um pet antes de alterar.");
                return;
            }
            else if (allFullfilled())
            {
                Product drug = new Product(txtName.Text, Convert.ToDouble(txtCost.Text))
                {
                    ProductId = Convert.ToInt64(txtId.Text)
                };

                drugService.Alter(drug);

                refreshDataGridView();
                resetForm();
            }
        }

        private void loadDrugData(Product drug)
        {
            txtId.Text   = Convert.ToString(drug.ProductId);
            txtName.Text = Convert.ToString(drug.Name);
            txtCost.Text = Convert.ToString(drug.Cost);
        }

        private long getDrugIdDgv(int rowIndex)
        {
            return Convert.ToInt32(dgvDrugs.Rows[rowIndex].Cells[0].Value);
        }

        private void dgvDrugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var productId = getDrugIdDgv(e.RowIndex);
                if (productId.Equals(null) || !(productId > 0))
                {
                    return;
                }
                loadDrugData(drugService.GetById(getDrugIdDgv(e.RowIndex)));
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                btnAlter.Enabled = false;
                btnRemove.Enabled = false;
            }
            else
            {
                btnAlter.Enabled = true;
                btnRemove.Enabled = true;
            }
        }

        private void dgvDrugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
