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
    public partial class FormOwner : Form
    {
        private OwnerService               ownerService               = new OwnerService();
        private AdressService              adressService              = new AdressService();
        private MedicalConsultationService medicalConsultationService = new MedicalConsultationService();
        private PetService                 petService                 = new PetService();
        private VetService                 vetService                 = new VetService();

        public FormOwner()
        {
            InitializeComponent();
            refreshDataGridView();
        }

        private void refreshDataGridView()
        {
            dgvOwner.DataSource = null;
            dgvOwner.DataSource = ownerService.ShowAll();
        }

        private void refreshDataGridViewAdressNull()
        {
            dgvAdress.DataSource = null;
        }

        private void refreshDataGridViewAdress()
        {
            dgvAdress.DataSource = null;
            List<Adress> adresses = null;
            if (adressService.ShowAll().Where(a => a.OwnerId == Convert.ToInt64(txtId.Text)) != null)
            {
                adresses = adressService.ShowAll().Where(a => a.OwnerId == Convert.ToInt64(txtId.Text)).ToList();
                foreach (var adress in adresses)
                {
                    adress.Owner = ownerService.GetById(adress.OwnerId);
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
            if (medicalConsultationService.ShowAll().Where(mc => mc.OwnerId == Convert.ToInt64(txtId.Text)) != null)
            {
                medicalConsultations = medicalConsultationService.ShowAll().Where(mc => mc.OwnerId == Convert.ToInt64(txtId.Text)).ToList();
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
                ownerService.Insert(new Owner(txtName.Text, txtCPF.Text, txtEmail.Text, txtTel.Text, txtCel.Text, dtBirth.Value));
                refreshDataGridView();
                resetForm();    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("É preciso selecionar um dono para remove-lo da base de dados.");
                txtId.BackColor = Color.LightSalmon;
                return;

            }
            else if (allFullfilled())
            {
                ownerService.Remove(Convert.ToInt64(txtId.Text));
                refreshDataGridView();
                resetForm();
            }
        }

        private void FormOwner_Load(object sender, EventArgs e)
        {

        }

        private void resetForm()
        {
            txtId.Clear();
            txtName.Clear();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterPets_Click(object sender, EventArgs e)
        {
            FormPet formPet = new FormPet();
            formPet.Show();
        }

        private long? GetOwnerIdDgv(int rowIndex)
        {
            if (rowIndex >= 0)
                return Convert.ToInt32(dgvOwner.Rows[rowIndex].Cells[0].Value);
            else
                return null;
        }

        private void loadOwnerData(Owner owner)
        {
            txtId.Text    = Convert.ToString(owner.OwnerId).Trim();
            txtName.Text  = owner.Name;
            txtCPF.Text   = owner.CPF;
            txtEmail.Text = owner.Email;
            txtTel.Text   = owner.Telephone;
            txtCel.Text   = owner.CellPhone;
            dtBirth.Value = owner.Birthday;
        }

        private void dgvOwner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var OwnerId = GetOwnerIdDgv(e.RowIndex);
            if (OwnerId.Equals(null))
            {
                return;
            }

            var owner = ownerService.GetById(Convert.ToInt64(OwnerId));

            dgvAdress.DataSource = null;
            dgvAdress.DataSource = adressService.ShowAll(owner);

            dgvConsult.DataSource = null;
            dgvConsult.DataSource = medicalConsultationService.ShowAll(owner);

            loadOwnerData(owner);
        }

        private void btnAdress_Click(object sender, EventArgs e)
        {
                var formAdress = new FormAdress();
                formAdress.Show();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            var formMedicalConsultation = new FormMedicalConsultation();
            formMedicalConsultation.Show();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("A caixa de Id não deve estar vazia, selecione um dono antes de alterar.");
                return;
            }
            else if (allFullfilled())
            {
                Owner owner = new Owner(txtName.Text, txtCPF.Text, txtEmail.Text, txtTel.Text, txtCel.Text, dtBirth.Value)
                {
                    OwnerId = Convert.ToInt64(txtId.Text)
                };

                ownerService.Alter(owner);
                
                refreshDataGridView();
                resetForm();
            }
        }

        private void dgvOwner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var OwnerId = GetOwnerIdDgv(e.RowIndex);
                if (OwnerId.Equals(null) || !(OwnerId > 0))
                {
                    return;
                }
                var owner = ownerService.GetById(Convert.ToInt64(OwnerId));

                dgvAdress.DataSource = null;
                dgvAdress.DataSource = adressService.ShowAll(owner);

                dgvConsult.DataSource = null;
                dgvConsult.DataSource = medicalConsultationService.ShowAll(owner);

                loadOwnerData(owner);
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
    }
}
