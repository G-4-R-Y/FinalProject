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
    public partial class FormExam : Form
    {
        private ServiceGeneric<Exam> examService = new ServiceGeneric<Exam>();

        public FormExam()
        {
            InitializeComponent();
            refreshDataGridView();
        }

        private void refreshDataGridView()
        {
            dgvExam.DataSource = null;
            dgvExam.DataSource = examService.ShowAll();
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

        private void FormExam_Load(object sender, EventArgs e)
        {

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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo id deve estar vazio para fazer um novo registro, resete o formulário para limpar os campos e tente novamente.");
            }
            else if (allFullfilled())
            {
                examService.Insert(new Exam(txtName.Text, Convert.ToDouble(txtCost.Text)));
                resetForm();
                refreshDataGridView();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo id deve estar preenchido para remover um registro, selecione um remédio e tente novamente.");
            }
            else if (allFullfilled())
            {
                examService.Remove(Convert.ToInt64(txtId.Text));
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
                Exam exam = new Exam(txtName.Text, Convert.ToDouble(txtCost.Text))
                {
                    ExamId = Convert.ToInt64(txtId.Text)
                };
                    

                examService.Alter(exam);

                refreshDataGridView();
                resetForm();
            }
        }

        private void loadExamData(Exam exam)
        {
            txtId.Text = Convert.ToString(exam.ExamId);
            txtName.Text = Convert.ToString(exam.Name);
            txtCost.Text = Convert.ToString(exam.Cost);
        }

        private long getExamIdDgv(int rowIndex)
        {
            return Convert.ToInt32(dgvExam.Rows[rowIndex].Cells[0].Value);
        }

        private void dgvDrugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var examId = getExamIdDgv(e.RowIndex);
                if (examId.Equals(null) || !(examId > 0))
                {
                    return;
                }
                loadExamData(examService.GetById(getExamIdDgv(e.RowIndex)));
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

        private void dgvExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
