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
    public partial class FormVet : Form
    {
        private ServiceGeneric<Vet>        vetService                 = new ServiceGeneric<Vet>();
        private PetService                 petService                 = new PetService();
        private AdressService              adressService              = new AdressService();
        private MedicalConsultationService medicalConsultationService = new MedicalConsultationService();
        private OwnerService               ownerService               = new OwnerService();

        public FormVet()
        {
            InitializeComponent();
            refreshDataGridView();
        }

        private void refreshDataGridView()
        {
            dgvVet.DataSource = null;
            dgvVet.DataSource = vetService.ShowAll();
        }

        private void refreshDataGridViewAdressNull()
        {
            dgvAdress.DataSource = null;
        }

        private void refreshDataGridViewAdress()
        {
            dgvAdress.DataSource = null;
            List<Adress> adresses = null;
            if (adressService.ShowAll().Where(a => a.VetId == Convert.ToInt64(txtId.Text)) != null)
            {
                adresses = adressService.ShowAll().Where(a => a.VetId == Convert.ToInt64(txtId.Text)).ToList();
                foreach (var adress in adresses)
                {
                    adress.Vet = vetService.GetById(adress.VetId);
                }
            }
            dgvAdress.DataSource = adresses;
        }

        private void refreshDataGridViewMedicalConsultationNull()
        {
            dgvConsult.DataSource = null;
        }

        private void refreshDataGridViewMedicalConsultation()
        {
            dgvConsult.DataSource = null;
            List<MedicalConsultation> medicalConsultations = null;
            if (medicalConsultationService.ShowAll().Where(mc => mc.VetId == Convert.ToInt64(txtId.Text)) != null)
            {
                medicalConsultations = medicalConsultationService.ShowAll().Where(mc => mc.VetId == Convert.ToInt64(txtId.Text)).ToList();
                foreach (var medicalConsultation in medicalConsultations)
                {
                    medicalConsultation.Vet = vetService.GetById(Convert.ToInt64(medicalConsultation.VetId));
                    medicalConsultation.Owner = ownerService.GetById(Convert.ToInt64(medicalConsultation.OwnerId));
                    medicalConsultation.Pet = petService.GetById(Convert.ToInt64(medicalConsultation.PetId));
                }
            }
            dgvConsult.DataSource = medicalConsultations;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool allFullfilled()
        {
            if (txtName.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo nome deve ser preenchido.");
                txtName.BackColor = Color.LightSalmon;
                return false;
            }
            else if (txtCRMV.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo CRMV deve ser preenchido.");
                txtCPF.BackColor = Color.LightSalmon;
                return false;
            }
            else if (!txtCPF.MaskCompleted)
            {
                MessageBox.Show("O campo CPF deve ser preenchido.");
                txtCPF.BackColor = Color.LightSalmon;
                return false;
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Os dados inseridos no campo email não atendem ao formato de um email.");
                txtEmail.BackColor = Color.LightSalmon;
                return false;
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("O email inserido é inválido.");
                txtEmail.BackColor = Color.LightSalmon;
                return false;
            }

            txtName.BackColor = DefaultBackColor;
            txtCPF.BackColor = DefaultBackColor;
            txtEmail.BackColor = DefaultBackColor;
            txtTel.BackColor = DefaultBackColor;
            txtCel.BackColor = DefaultBackColor;
            return true;
        }

        private void resetForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtCRMV.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            txtCel.Clear();
            dtBirth.Value = DateTime.Today;
            refreshDataGridView();
            refreshDataGridViewAdressNull();
            refreshDataGridViewMedicalConsultationNull();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("A caixa de Id deve estar vazia, aperte em resetar para limpa-la.");
                txtId.BackColor = Color.LightSalmon;
                return;
            }

            else if (allFullfilled())
            {
                vetService.Insert(new Vet(txtName.Text, txtCRMV.Text, txtCPF.Text, txtEmail.Text, txtTel.Text, txtCel.Text, dtBirth.Value));
                refreshDataGridView();
                resetForm();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("É preciso selecionar um dono para remove-lo da base de dados.");
                txtId.BackColor = Color.LightSalmon;
                return;

            }
            else if (allFullfilled())
            {
                vetService.Remove(Convert.ToInt64(txtId.Text));
                refreshDataGridView();
                resetForm();
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("A caixa de Id não deve estar vazia, selecione um veterinário antes de alterar.");
                return;
            }
            else if (allFullfilled())
            {
                Vet vet = new Vet(txtName.Text, txtCRMV.Text, txtCPF.Text, txtEmail.Text, txtTel.Text, txtCel.Text, dtBirth.Value)
                {
                    VetId = Convert.ToInt64(txtId.Text)
                };

                vetService.Alter(vet);

                refreshDataGridView();
                resetForm();
            }
        }

        private void loadVetData(Vet vet)
        {
            txtId.Text    = Convert.ToString(vet.VetId).Trim();
            txtName.Text  = vet.Name;
            txtCRMV.Text  = vet.CRMV;
            txtCPF.Text   = vet.CPF;
            txtEmail.Text = vet.Email;
            txtTel.Text   = vet.Telephone;
            txtCel.Text   = vet.CellPhone;
            dtBirth.Value = vet.Birthday;
        }

        private long? GetVetIdDgv(int rowIndex)
        {
            if (rowIndex >= 0)
                return Convert.ToInt32(dgvVet.Rows[rowIndex].Cells[0].Value);
            else
                return null;
        }

        private void dgvOwner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var VetId = GetVetIdDgv(e.RowIndex);
                if (VetId.Equals(null) || !(VetId > 0))
                {
                    return;
                }
                var vet = vetService.GetById(Convert.ToInt64(VetId));

                dgvAdress.DataSource = null;
                dgvAdress.DataSource = adressService.ShowAll(vet);

                dgvConsult.DataSource = null;
                dgvConsult.DataSource = medicalConsultationService.ShowAll(vet);

                loadVetData(vet);
            }
        }

        private void btnAdress_Click(object sender, EventArgs e)
        {
            FormAdressVet formAdressPet = new FormAdressVet();
            formAdressPet.Show();
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

        private void dgvVet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
