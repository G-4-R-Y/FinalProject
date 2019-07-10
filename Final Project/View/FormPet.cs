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
    public partial class FormPet : Form
    {
        private PetService                 petService                 = new PetService();
        private OwnerService               ownerService               = new OwnerService();
        private ConsultationProductService ConsultationProductService = new ConsultationProductService();
        private ServiceGeneric<Product>    drugService                = new ServiceGeneric<Product>();
        private MedicalConsultationService medicalConsultationService = new MedicalConsultationService();
        private ServiceGeneric<Product>    productService             = new ServiceGeneric<Product>();
        private VetService                 vetService                 = new VetService();

        public FormPet()
        {
            InitializeComponent();
            populateOwnerCombobox();
            refreshDataGridView();
        }
        
        private void populateOwnerCombobox()
        {
            List<Owner> owners = ownerService.ShowAll().OrderBy(o => o.Name).ToList<Owner>();
            owners.Insert(0, new Owner("Nome", "CPF") { OwnerId = -1 });

            cbOwner.DisplayMember = "Name";
            cbOwner.ValueMember = "OwnerId";
            cbOwner.DataSource = owners;
        }

        private bool allFullfilled()
        {
            if (Convert.ToInt64(cbOwner.SelectedValue) == -1)
            {
                MessageBox.Show("É necessário selecionar um dono para o novo pet.");
                cbOwner.BackColor = Color.LightSalmon;
                return false;
            }
            else if (txtName.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo nome deve ser preenchido.");
                txtName.BackColor = Color.LightSalmon;
                return false;
            }
            else if (txtSpecies.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo espécie deve ser preenchido.");
                txtSpecies.BackColor = Color.LightSalmon;
                return false;
            }
            else
            {
                txtName.BackColor = DefaultBackColor;
                txtSpecies.BackColor = DefaultBackColor;
                cbOwner.BackColor = DefaultBackColor;
                return true;
            }
        }

        //refresh inicial (Mostra todos os pets)
        private void refreshDataGridView()
        {
            dgvPets.DataSource = null;
            List<Pet> pets = null;
            if (petService.ShowAll() != null)
            {
                pets = petService.ShowAll().ToList();
                foreach (var pet in pets)
                {
                    pet.OwnedBy = ownerService.GetById(pet.OwnerId);
                }
            }
            dgvPets.DataSource = pets;
        }

        //refresh para mostrar os pets do owner selecionado
        private void refreshDataGridView(Owner owner)
        {
            dgvPets.DataSource = null;
            List<Pet> pets = null;
            if (petService.ShowAll(owner) != null)
            {
                pets = petService.ShowAll(owner).ToList();
                foreach (var pet in pets)
                {
                    pet.OwnedBy = ownerService.GetById(pet.OwnerId);
                }
            }
            dgvPets.DataSource = pets;
        }

        private void refreshDataGridViewPrescriptedDrugs(long? petId)
        {
            dgvPrescriptedDrugs.DataSource = null;
            List<ConsultationProduct> consultationProducts = null;
            if (ConsultationProductService.ShowAll(petId) != null)
            {
                consultationProducts = ConsultationProductService.ShowAll(petId).ToList();
                foreach (var consultationProduct in consultationProducts)
                {
                    consultationProduct.MedicalConsultation = medicalConsultationService.GetById(consultationProduct.MedicalConsultationId);
                    consultationProduct.Product = productService.GetById(consultationProduct.ProductId);
                }
            }
            dgvPrescriptedDrugs.DataSource = consultationProducts;
        }

        private void refreshDataGridViewMedicalConsultations(Pet pet)
        {
            dgvMedicalConsultations.DataSource = null;
            List<MedicalConsultation> medicalConsultations = null;
            if (medicalConsultationService.ShowAll(pet) != null)
            {
                medicalConsultations = medicalConsultationService.ShowAll(pet).ToList();
                foreach (var medicalConsultation in medicalConsultations)
                {
                    medicalConsultation.Vet = vetService.GetById(Convert.ToInt64(medicalConsultation.VetId));
                    medicalConsultation.Owner = ownerService.GetById(Convert.ToInt64(medicalConsultation.OwnerId));
                    medicalConsultation.Pet = petService.GetById(Convert.ToInt64(medicalConsultation.PetId));
                }
            }
            dgvMedicalConsultations.DataSource = medicalConsultations;
        }

        //carrega os dados do pet selecionado nos controles
        private void loadPetData(Pet pet)
        {
            Owner owner = ownerService.GetById(pet.OwnerId.Value);
            owner.PetsOwned = (List<Pet>) petService.ShowAll(owner);

            cbOwner.SelectedValue = 0;
            cbOwner.SelectedValue = owner.OwnerId;
            
            txtId.Text = $"{ pet.PetId}";
            txtName.Text = pet.Name;
            dtBirthday.Value = pet.Birthday;
            txtSpecies.Text = pet.Species;
        }

        //obtém o PetId do pet selecionado no dgv
        private int getPetIdDgv(int rowIndex)
        {
            return Convert.ToInt32(dgvPets.Rows[rowIndex].Cells[0].Value);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InsBtn_Click(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(""))
            {
                MessageBox.Show("A caixa de Id deve estar vazia, aperte em resetar para limpa-la.");
                return;
            }
            else if (allFullfilled())
            {
                var ownerId = Convert.ToInt64(cbOwner.SelectedValue);
                Owner petOwner = (Owner)ownerService.GetById(ownerId);
                Pet newPet = new Pet(txtName.Text, dtBirthday.Value, petOwner.OwnerId, txtSpecies.Text)
                {
                    //PetId = (txtId.Text.Trim() == string.Empty) ? 0 : Convert.ToInt64(txtId.Text)
                };

                Composition.AddSlice<Owner, Pet>(petOwner, newPet);

                petService.Insert(newPet);

                resetForm();


                refreshDataGridView(petOwner);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormPet_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbOwner_ValueMemberChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt64(cbOwner.SelectedValue) > 0)
            {
                var value = Convert.ToInt64(cbOwner.SelectedValue);
                Owner currentOwner = ownerService.GetById(value);
                refreshDataGridView(currentOwner);
            }
        }

        private void dgvPets_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var petId = getPetIdDgv(e.RowIndex);
                if (petId.Equals(null) || !(petId > 0))
                {
                    return;
                }
                loadPetData(petService.GetById(getPetIdDgv(e.RowIndex)));
                refreshDataGridViewPrescriptedDrugs(Convert.ToInt64(txtId.Text));
                refreshDataGridViewMedicalConsultations(petService.GetById(Convert.ToInt64(txtId.Text)));
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
                var ownerId = Convert.ToInt64(cbOwner.SelectedValue);
                Owner petOwner = (Owner)ownerService.GetById(ownerId);
                Pet newPet = new Pet(txtName.Text, dtBirthday.Value, petOwner.OwnerId, txtSpecies.Text)
                {
                    PetId = Convert.ToInt64(txtId.Text)
                };

                Composition.AddSlice<Owner, Pet>(petOwner, newPet);

                petService.Alter(newPet);

                refreshDataGridView(petOwner);

                resetForm();
            }
        }

        private void resetForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            dtBirthday.Value = DateTime.Today;
            cbOwner.SelectedIndex = 0;
            refreshDataGridView();
            dgvMedicalConsultations.DataSource = null;
            dgvPrescriptedDrugs.DataSource = null;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("É preciso selecionar um pet para remove-lo da base de dados.");
                return;
            }
            else
            {
                petService.Remove(Convert.ToInt64(txtId.Text));
                refreshDataGridView();
                resetForm();
            }
        }

        private void txtId_TextChanged_1(object sender, EventArgs e)
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
