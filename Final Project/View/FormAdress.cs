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
    public partial class FormAdress : Form
    {
        public OwnerService  ownerService  = new OwnerService();
        public AdressService adressService = new AdressService();

        public FormAdress()
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
        
        private void refreshDataGridView()
        {
            dgvAdress.DataSource = null;
            List<Adress> adresses = null;
            if (adressService.ShowAll().Where(a => a.VetId == null) != null)
            {
                adresses = adressService.ShowAll().Where(a => a.VetId == null).ToList();
                foreach (Adress adress in adresses)
                {
                    adress.Owner = ownerService.GetById(adress.OwnerId);
                }
            }
            dgvAdress.DataSource = adresses;
        }

        //refresh para mostrar os adresses do owner selecionado
        private void refreshDataGridView(Owner owner)
        {
            dgvAdress.DataSource = null;
            List<Adress> adresses = null;
            if (adressService.ShowAll(owner) != null)
            {
                adresses = adressService.ShowAll(owner).ToList();
                foreach (Adress adress in adresses)
                {
                    adress.Owner = ownerService.GetById(adress.OwnerId);
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
            if (adress == null)
            {
                return;
            }

            Owner owner = ownerService.GetById(adress.OwnerId.Value);
            owner.Adress = (List<Adress>)adressService.ShowAll(owner);

            cbOwner.SelectedValue = 0;
            cbOwner.SelectedValue = owner.OwnerId;

            txtId.Text = Convert.ToString(adress.AdressId);
            txtStreet.Text = adress.Street;
            txtDetails.Text = adress.Details;
            txtNeighborhood.Text = adress.Neighborhood;
            txtCity.Text = adress.City;
            txtPostal.Text = Convert.ToString(adress.PostalCode);
            txtNumber.Text = Convert.ToString(adress.Number);
        }
        
        //obtém o AdressId do adress selecionado no dgv
        private int getAdressIdDgv(int rowIndex)
        {
            return Convert.ToInt32(dgvAdress.Rows[rowIndex].Cells[0].Value);
        }
        
        private void cbOwner_ValueMemberChanged(object sender, EventArgs e)
        {
            var value = Convert.ToInt64(cbOwner.SelectedValue);
            Owner currentOwner = ownerService.GetById(value);
            refreshDataGridView(currentOwner);
        }

        private void FormAdress_Load(object sender, EventArgs e)
        {

        }

        private void dgvAdress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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
                var ownerId = Convert.ToInt64(cbOwner.SelectedValue);
                Owner adressOwner = (Owner)ownerService.GetById(ownerId);
                Adress newAdress = new Adress(txtStreet.Text, txtDetails.Text, txtNeighborhood.Text, txtCity.Text, txtPostal.Text, Convert.ToInt32(txtNumber.Text))
                {
                    OwnerId = Convert.ToInt64(adressOwner.OwnerId),
                    VetId = null
                };

                Composition.AddSlice(adressOwner, newAdress);

                adressService.InsertOwner(newAdress);

                resetForm();
                
                refreshDataGridView(adressOwner);
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                MessageBox.Show("É preciso selecionar um endereço para altera-lo na base de dados.");
                return;
            }
            else if (allFullfilled())
            {
                var ownerId = Convert.ToInt64(cbOwner.SelectedValue);
                Owner adressOwner = (Owner)ownerService.GetById(ownerId);
                Adress newAdress = new Adress(txtStreet.Text, txtDetails.Text, txtNeighborhood.Text, txtCity.Text, txtPostal.Text, Convert.ToInt32(txtNumber.Text))
                {
                    AdressId = Convert.ToInt64(txtId.Text),
                    OwnerId  = ownerId,
                    VetId    = null
                };

                adressService.AlterOwner(newAdress);

                resetForm();

                refreshDataGridView(adressOwner);
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
                Owner owner = (Owner)cbOwner.SelectedItem;
                refreshDataGridView(ownerService.GetById(Convert.ToInt64(owner.OwnerId)));
                resetForm();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void cbOwner_SelectedIndexChanged(object sender, EventArgs e)
        {

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
