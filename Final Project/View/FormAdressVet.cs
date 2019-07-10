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
    public partial class FormAdressVet : Form
    {
        public FormAdressVet()
        {
            InitializeComponent();
            populateVetCombobox();
            refreshDataGridView();
        }
        public VetService vetService = new VetService();
        public AdressService adressService = new AdressService();


        private void populateVetCombobox()
        {
            List<Vet> vets = vetService.ShowAll().OrderBy(o => o.Name).ToList<Vet>();
            vets.Insert(0, new Vet("Nome", "CPF") { VetId = -1 });

            cbOwner.DisplayMember = "Name";
            cbOwner.ValueMember = "VetId";
            cbOwner.DataSource = vets;
        }

        private void refreshDataGridView()
        {
            dgvAdress.DataSource = null;
            List<Adress> adresses = null;
            if (adressService.ShowAll().Where(a => a.OwnerId == null) != null)
            {
                adresses = adressService.ShowAll().Where(a => a.OwnerId == null).ToList();
                foreach (var adress in adresses)
                {
                    adress.Vet = vetService.GetById(adress.VetId);
                }
            }
            dgvAdress.DataSource = adresses;
        }

        //refresh para mostrar os adresses do owner selecionado
        private void refreshDataGridView(Vet vet)
        {
            dgvAdress.DataSource = null;
            List<Adress> adresses = null;
            if (adressService.ShowAll(vet) != null)
            {
                adresses = adressService.ShowAll(vet).ToList();
                foreach (var adress in adresses)
                {
                    adress.Vet = vetService.GetById(adress.VetId);
                }
            }
            dgvAdress.DataSource = adresses;
        }

        private void resetForm()
        {
            txtId.Clear();
            txtStreet.Clear();
            txtDetails.Clear();
            txtNeighborhood.Clear();
            txtCity.Clear();
            txtPostal.Clear();
            txtNumber.Clear();
            cbOwner.SelectedIndex = 0;
        }

        private bool allFullfilled()
        {
            if (Convert.ToInt64(cbOwner.SelectedValue) == -1)
            {
                MessageBox.Show("É necessário selecionar um dono para o novo endereço.");
                cbOwner.BackColor = Color.LightSalmon;
                return false;
            }
            else if (txtStreet.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo rua deve ser preenchido.");
                txtStreet.BackColor = Color.LightSalmon;
                return false;
            }
            else if (txtNeighborhood.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo bairro deve ser preenchido.");
                txtNeighborhood.BackColor = Color.LightSalmon;
                return false;
            }
            else if (txtCity.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo cidade deve ser preenchido.");
                txtCity.BackColor = Color.LightSalmon;
                return false;
            }
            else if (txtPostal.Text.Equals(String.Empty) || txtPostal.Text.Length != 8)
            {
                MessageBox.Show("O campo CEP deve ser preenchido e ter 8 caractéres.");
                txtPostal.BackColor = Color.LightSalmon;
                return false;
            }
            else if (txtNumber.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo número deve ser preenchido.");
                txtNumber.BackColor = Color.LightSalmon;
                return false;
            }
            else
            {
                txtStreet.BackColor = DefaultBackColor;
                txtDetails.BackColor = DefaultBackColor;
                txtNeighborhood.BackColor = DefaultBackColor;
                txtCity.BackColor = DefaultBackColor;
                txtPostal.BackColor = DefaultBackColor;
                txtNumber.BackColor = DefaultBackColor;
                cbOwner.BackColor = DefaultBackColor;
                return true;
            }
        }

        //carrega os dados do endereco selecionado nos controles
        private void loadAdressData(Adress adress)
        {
            Vet vet = vetService.GetById(adress.VetId.Value);
            vet.Adress = (List<Adress>)adressService.ShowAll(vet);

            cbOwner.SelectedValue = 0;
            cbOwner.SelectedValue = vet.VetId;

            txtId.Text = Convert.ToString(adress.AdressId);
            txtStreet.Text = adress.Street;
            txtDetails.Text = adress.Details;
            txtNeighborhood.Text = adress.Neighborhood;
            txtCity.Text = adress.City;
            txtPostal.Text = Convert.ToString(adress.PostalCode);
            txtNumber.Text = Convert.ToString(adress.Number);
        }

        //obtém o AdressId do adress selecionado no dgv
        private int getVetIdDgv(int rowIndex)
        {
            return Convert.ToInt32(dgvAdress.Rows[rowIndex].Cells[0].Value);
        }

        private void cbOwner_ValueMemberChanged(object sender, EventArgs e)
        {
            var value = Convert.ToInt64(cbOwner.SelectedValue);
            Vet currentVet = vetService.GetById(value);
            refreshDataGridView(currentVet);
        }

        private void FormAdress_Load(object sender, EventArgs e)
        {

        }

        private long getAdressIdDgv(int rowIndex)
        {
            return Convert.ToInt32(dgvAdress.Rows[rowIndex].Cells[0].Value);
        }

        private void dgvAdress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                var adressId = getAdressIdDgv(e.RowIndex);
                if (adressId.Equals(null) || !(adressId > 0))
                {
                    return;
                }
            
                loadAdressData(adressService.GetById(getAdressIdDgv(e.RowIndex)));
            }
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
                var vetId = Convert.ToInt64(cbOwner.SelectedValue);
                Vet adressVet = (Vet)vetService.GetById(vetId);
                Adress newAdress = new Adress(txtStreet.Text, txtDetails.Text, txtNeighborhood.Text, txtCity.Text, txtPostal.Text, Convert.ToInt32(txtNumber.Text))
                {
                    VetId = Convert.ToInt64(adressVet.VetId)
                };

                adressService.InsertVet(newAdress);

                resetForm();

                refreshDataGridView(adressVet);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("É preciso selecionar um endereço para remove-lo da base de dados.");
                return;
            }
            else
            {
                adressService.Remove(Convert.ToInt64(txtId.Text));
                Vet vet = (Vet)cbOwner.SelectedItem;
                refreshDataGridView(vetService.GetById(Convert.ToInt64(vet.VetId)));
                resetForm();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnAlter_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                MessageBox.Show("É preciso selecionar um endereço para altera-lo na base de dados.");
                return;
            }
            else if (allFullfilled())
            {
                var vetId = Convert.ToInt64(cbOwner.SelectedValue);
                Vet adressVet = (Vet)vetService.GetById(vetId);
                Adress newAdress = new Adress(txtStreet.Text, txtDetails.Text, txtNeighborhood.Text, txtCity.Text, txtPostal.Text, Convert.ToInt32(txtNumber.Text))
                {
                    AdressId = Convert.ToInt64(txtId.Text),
                    VetId = Convert.ToInt64(adressVet.VetId),
                    OwnerId = null
                };

                adressService.AlterOwner(newAdress);

                resetForm();

                refreshDataGridView(adressVet);
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("É preciso selecionar um endereço para remove-lo da base de dados.");
                return;
            }
            else
            {
                adressService.Remove(Convert.ToInt64(txtId.Text));
                Vet vet = (Vet)cbOwner.SelectedItem;
                refreshDataGridView(vetService.GetById(Convert.ToInt64(vet.VetId)));
                resetForm();
            }
        }

        private void dgvAdress_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var vetId = getVetIdDgv(e.RowIndex);

                if (vetId.Equals(null) || !(vetId > 0))
                {
                    return;
                }

                loadAdressData(adressService.GetById(getVetIdDgv(e.RowIndex)));
            }
        }

        private void cbOwner_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = Convert.ToInt64(cbOwner.SelectedValue);
            Vet currentVet = vetService.GetById(value);
            refreshDataGridView(currentVet);
        }

        private void InsBtn_Click_1(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(""))
            {
                MessageBox.Show("A caixa de Id deve estar vazia, aperte em resetar para limpa-la.");
                return;
            }
            else if (allFullfilled())
            {
                var vetId = Convert.ToInt64(cbOwner.SelectedValue);
                Vet adressVet = (Vet)vetService.GetById(vetId);
                Adress newAdress = new Adress(txtStreet.Text, txtDetails.Text, txtNeighborhood.Text, txtCity.Text, txtPostal.Text, Convert.ToInt32(txtNumber.Text))
                {
                    VetId = Convert.ToInt64(adressVet.VetId),
                    OwnerId = null
                };

                adressService.InsertVet(newAdress);

                resetForm();

                refreshDataGridView(adressVet);
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            resetForm();
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

        private void dgvAdress_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
