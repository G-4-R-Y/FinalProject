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
    public partial class FormMedicalConsultation : Form
    {
        private OwnerService ownerService = new OwnerService();
        private MedicalConsultationService medicalConsultationService = new MedicalConsultationService();
        private PetService petService = new PetService();
        private VetService vetService = new VetService();
        private ConsultationProductService consultationProductService = new ConsultationProductService();
        private ConsultationExamService consultationExamService = new ConsultationExamService();
        private ServiceGeneric<Product> productService = new ServiceGeneric<Product>();
        private ServiceGeneric<Exam> examService = new ServiceGeneric<Exam>();


        private MedicalConsultation currentlyBeingRegistered = null;
        private List<ConsultationProduct> currentlyBeingPrescribedProducts = null;
        private List<ConsultationExam> currentlyBeingPrescribedExams = null;

        public FormMedicalConsultation()
        {
            InitializeComponent();
            populateVetCombobox();
            populateOwnerCombobox();
            populatePetCombobox();
            populateProductCombobox();
            populateExamCombobox();
            refreshDataGridView();

            disable();

        }

        private void disable()
        {
            btnAlter.Enabled = false;
            btnRemove.Enabled = false;

            cbPrescribedProducts.Enabled = false;
            txtDose.Enabled = false;
            txtFrequency.Enabled = false;
            btnPrescribeProduct.Enabled = false;
            btnRemoveProduct.Enabled = false;
            btnResetProduct.Enabled = false;

            cbPrescribedExams.Enabled = false;
            btnPrescribeExam.Enabled = false;
            btnRemoveExam.Enabled = false;
            btnResetExam.Enabled = false;
        }

        private void populateVetCombobox()
        {
            List<Vet> vets = vetService.ShowAll().OrderBy(v => v.Name).ToList<Vet>();
            vets.Insert(0, new Vet("Nome", "CPF") { VetId = -1 });

            cbVet.DisplayMember = "Name";
            cbVet.ValueMember = "VetId";
            cbVet.DataSource = vets;
        }

        private void populateOwnerCombobox()
        {
            List<Owner> owners = ownerService.ShowAll().OrderBy(o => o.Name).ToList<Owner>();
            owners.Insert(0, new Owner("Nome", "CPF") { OwnerId = -1 });

            cbOwner.DisplayMember = "Name";
            cbOwner.ValueMember = "OwnerId";
            cbOwner.DataSource = owners;
        }

        private void populatePetCombobox()
        {
            List<Pet> pets = petService.ShowAll().OrderBy(p => p.Name).ToList<Pet>();
            pets.Insert(0, new Pet("Nome", "Espécie") { PetId = -1 });

            cbPet.DisplayMember = "Name";
            cbPet.ValueMember = "PetId";
            cbPet.DataSource = pets;
        }

        private void populateProductCombobox()
        {
            List<Product> products = productService.ShowAll().OrderBy(p => p.Name).ToList<Product>();
            products.Insert(0, new Product("Nome", 00) { ProductId = -1 });

            cbPrescribedProducts.DisplayMember = "Name";
            cbPrescribedProducts.ValueMember = "ProductId";
            cbPrescribedProducts.DataSource = products;
        }

        private void populateExamCombobox()
        {
            List<Exam> exams = examService.ShowAll().OrderBy(e => e.Name).ToList<Exam>();
            exams.Insert(0, new Exam("Nome", 00) { ExamId = -1 });

            cbPrescribedExams.DisplayMember = "Name";
            cbPrescribedExams.ValueMember = "ExamId";
            cbPrescribedExams.DataSource = exams;
        }

        //refresh inicial (Mostra todas as consultas agendadas)
        private void refreshDataGridView()
        {
            dgvMedicalConsultation.DataSource = null;
            IList<MedicalConsultation> medicalConsultations = null;
            if (medicalConsultationService.ShowAll() != null)
            {
                medicalConsultations = medicalConsultationService.ShowAll();
                foreach (var medicalConsultation in medicalConsultations)
                {
                    medicalConsultation.Vet = vetService.GetById(Convert.ToInt64(medicalConsultation.VetId));
                    medicalConsultation.Owner = ownerService.GetById(Convert.ToInt64(medicalConsultation.OwnerId));
                    medicalConsultation.Pet = petService.GetById(Convert.ToInt64(medicalConsultation.PetId));
                }
            }
            dgvMedicalConsultation.DataSource = medicalConsultations;
        }

        //Diário
        private void refreshDataGridViewDaily()
        {
            dgvMedicalConsultation.DataSource = null;
            IList<MedicalConsultation> medicalConsultations = null;

            if (medicalConsultationService.ShowAll().Where(m => m.AppointmentDate.Date == DateTime.Today.Date) != null)
            {
                medicalConsultations = medicalConsultationService.ShowAll().Where(m => m.AppointmentDate == DateTime.Today).ToList();
                foreach (var medicalConsultation in medicalConsultations)
                {
                    medicalConsultation.Vet = vetService.GetById(Convert.ToInt64(medicalConsultation.VetId));
                    medicalConsultation.Owner = ownerService.GetById(Convert.ToInt64(medicalConsultation.OwnerId));
                    medicalConsultation.Pet = petService.GetById(Convert.ToInt64(medicalConsultation.PetId));
                }
            }
            dgvMedicalConsultation.DataSource = medicalConsultations;
        }

        private bool DatesAreInTheSameWeek(DateTime date1, DateTime date2)
        {
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var d1 = date1.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date1));
            var d2 = date2.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date2));

            return d1 == d2;
        }

        //Semanal
        private void refreshDataGridViewWeekly()
        {
            dgvMedicalConsultation.DataSource = null;
            IList<MedicalConsultation> medicalConsultations = null;

            if (medicalConsultationService.ShowAll().Where(m => DatesAreInTheSameWeek(m.AppointmentDate, DateTime.Today) && m.AppointmentDate.Month == DateTime.Today.Month && m.AppointmentDate.Year == DateTime.Today.Year) != null)
            {
                medicalConsultations = medicalConsultationService.ShowAll().Where(m => DatesAreInTheSameWeek(m.AppointmentDate, DateTime.Today) && m.AppointmentDate.Month == DateTime.Today.Month && m.AppointmentDate.Year == DateTime.Today.Year).ToList();
                foreach (var medicalConsultation in medicalConsultations)
                {
                    medicalConsultation.Vet = vetService.GetById(Convert.ToInt64(medicalConsultation.VetId));
                    medicalConsultation.Owner = ownerService.GetById(Convert.ToInt64(medicalConsultation.OwnerId));
                    medicalConsultation.Pet = petService.GetById(Convert.ToInt64(medicalConsultation.PetId));
                }
            }
            dgvMedicalConsultation.DataSource = medicalConsultations;
        }

        //Mensal
        private void refreshDataGridViewMonthly()
        {
            dgvMedicalConsultation.DataSource = null;
            IList<MedicalConsultation> medicalConsultations = null;

            if (medicalConsultationService.ShowAll().Where(m => m.AppointmentDate.Month == DateTime.Today.Month && m.AppointmentDate.Year == DateTime.Today.Year) != null)
            {
                medicalConsultations = medicalConsultationService.ShowAll().Where(m => m.AppointmentDate.Month == DateTime.Today.Month && m.AppointmentDate.Year == DateTime.Today.Year).ToList();
                foreach (var medicalConsultation in medicalConsultations)
                {
                    medicalConsultation.Vet = vetService.GetById(Convert.ToInt64(medicalConsultation.VetId));
                    medicalConsultation.Owner = ownerService.GetById(Convert.ToInt64(medicalConsultation.OwnerId));
                    medicalConsultation.Pet = petService.GetById(Convert.ToInt64(medicalConsultation.PetId));
                }
            }
            dgvMedicalConsultation.DataSource = medicalConsultations;
        }

        private void refreshDataGridView(Vet vet)
        {
            dgvMedicalConsultation.DataSource = null;
            List<MedicalConsultation> medicalConsultations = null;

            if (medicalConsultationService.ShowAll(vet) != null)
            {
                medicalConsultations = medicalConsultationService.ShowAll(vet).ToList();
                foreach (var medicalConsultation in medicalConsultations)
                {
                    medicalConsultation.Vet = vetService.GetById(Convert.ToInt64(medicalConsultation.VetId));
                    medicalConsultation.Owner = ownerService.GetById(Convert.ToInt64(medicalConsultation.OwnerId));
                    medicalConsultation.Pet = petService.GetById(Convert.ToInt64(medicalConsultation.PetId));
                }
            }
            dgvMedicalConsultation.DataSource = medicalConsultations;
        }

        private void refreshDataGridView(Owner owner)
        {
            dgvMedicalConsultation.DataSource = null;
            List<MedicalConsultation> medicalConsultations = null;

            if (medicalConsultationService.ShowAll(owner) != null)
            {
                medicalConsultations = medicalConsultationService.ShowAll(owner).ToList();
                foreach (var medicalConsultation in medicalConsultations)
                {
                    medicalConsultation.Vet = vetService.GetById(Convert.ToInt64(medicalConsultation.VetId));
                    medicalConsultation.Owner = ownerService.GetById(Convert.ToInt64(medicalConsultation.OwnerId));
                    medicalConsultation.Pet = petService.GetById(Convert.ToInt64(medicalConsultation.PetId));
                }
            }
            dgvMedicalConsultation.DataSource = medicalConsultations;
        }

        private void refreshDataGridView(Pet pet)
        {
            dgvMedicalConsultation.DataSource = null;
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
            dgvMedicalConsultation.DataSource = medicalConsultations;
        }

        private void refreshDataGridViewPrescriptedProducts()
        {
            dgvPrescribedProduct.DataSource = null;

            if (!txtId.Text.Equals(String.Empty))
            {
                IList<ConsultationProduct> consultationProducts = null;
                if (consultationProductService.ShowAll().Where(cp => cp.MedicalConsultationId == Convert.ToInt64(txtId.Text)) != null)
                {
                    consultationProducts = consultationProductService.ShowAll().Where(cp => cp.MedicalConsultationId == Convert.ToInt64(txtId.Text)).ToList();
                    foreach (var consultationProduct in consultationProducts)
                    {
                        consultationProduct.Product = productService.GetById(Convert.ToInt64(consultationProduct.ProductId));
                        consultationProduct.MedicalConsultation = medicalConsultationService.GetById(Convert.ToInt64(consultationProduct.MedicalConsultationId));
                    }
                }
                dgvPrescribedProduct.DataSource = consultationProducts;
            }
        }

        private void refreshDataGridViewPrescriptedExams()
        {
            dgvPrescribedExam.DataSource = null;

            if (!txtId.Text.Equals(String.Empty))
            {
                IList<ConsultationExam> consultationExams = null;
                if (consultationExamService.ShowAll().Where(ce => ce.MedicalConsultationId == Convert.ToInt64(txtId.Text)) != null)
                {
                    consultationExams = consultationExamService.ShowAll().Where(ce => ce.MedicalConsultationId == Convert.ToInt64(txtId.Text)).ToList();
                    foreach (var consultationExam in consultationExams)
                    {
                        consultationExam.Exam = examService.GetById(Convert.ToInt64(consultationExam.ExamId));
                        consultationExam.MedicalConsultation = medicalConsultationService.GetById(Convert.ToInt64(consultationExam.MedicalConsultationId));
                    }
                }
                dgvPrescribedExam.DataSource = consultationExams;
            }
        }

        private void resetFormPrescriptProduct()
        {
            txtIdConsultationProduct.Clear();
            cbPrescribedProducts.SelectedIndex = 0;
            txtDose.Clear();
            txtFrequency.Clear();
            
            cbPrescribedProducts.BackColor = DefaultBackColor;
            txtDose.BackColor = DefaultBackColor;
            txtFrequency.BackColor = DefaultBackColor;
        }

        private void resetFormPrescriptExam()
        {
            txtIdConsultationExam.Clear();
            cbPrescribedExams.SelectedIndex = 0;

            cbPrescribedExams.BackColor = DefaultBackColor;
        }

        private void resetForm()
        {
            txtId.Clear();
            dtScheduleDate.Value = DateTime.Today;
            cbVet.SelectedIndex = 0;
            cbOwner.SelectedIndex = 0;
            cbPet.SelectedIndex = 0;

            currentlyBeingRegistered = null;

            currentlyBeingPrescribedProducts = null;
            refreshDataGridViewPrescriptedProducts();

            currentlyBeingPrescribedExams = null;
            refreshDataGridViewPrescriptedExams();

            resetFormPrescriptProduct();
            resetFormPrescriptExam();

            cbVet.BackColor = DefaultBackColor;
            cbOwner.BackColor = DefaultBackColor;
            cbPet.BackColor = DefaultBackColor;
        }

        private bool allFullfilled()
        {
            if (Convert.ToInt64(cbVet.SelectedValue) == -1)
            {
                MessageBox.Show("É necessário selecionar um veterinário para a consulta.");
                cbVet.BackColor = Color.LightSalmon;
                cbOwner.BackColor = DefaultBackColor;
                cbPet.BackColor = DefaultBackColor;
                return false;
            }
            else if (Convert.ToInt64(cbOwner.SelectedValue) == -1)
            {
                MessageBox.Show("É necessário selecionar um dono para a consulta.");
                cbOwner.BackColor = Color.LightSalmon;
                cbVet.BackColor = DefaultBackColor;
                cbPet.BackColor = DefaultBackColor;
                return false;
            }
            else if (Convert.ToInt64(cbOwner.SelectedValue) == -1)
            {
                MessageBox.Show("É necessário selecionar um pet para a consulta.");
                cbPet.BackColor = Color.LightSalmon;
                cbVet.BackColor = DefaultBackColor;
                cbOwner.BackColor = DefaultBackColor;
                return false;
            }

            cbVet.BackColor = DefaultBackColor;
            cbOwner.BackColor = DefaultBackColor;
            cbPet.BackColor = DefaultBackColor;
            return true;
        }

        private bool allFullfilledProductPrescription()
        {
            if (Convert.ToInt64(cbPrescribedProducts.SelectedValue) == -1)
            {
                MessageBox.Show("É necessário selecionar um remédio para prescreve-lo.");
                cbPrescribedProducts.BackColor = Color.LightSalmon;
                txtDose.BackColor = DefaultBackColor;
                txtFrequency.BackColor = DefaultBackColor;
                return false;
            }
            else if (txtDose.Text.Equals(String.Empty))
            {
                MessageBox.Show("É necessário inserir a dose que deve ser aplicada.");
                txtDose.BackColor = Color.LightSalmon;
                cbPrescribedProducts.BackColor = DefaultBackColor;
                txtFrequency.BackColor = DefaultBackColor;
                return false;
            }
            else if (txtFrequency.Text.Equals(String.Empty))
            {
                MessageBox.Show("É necessário inserir a frequência com a qual o remédio deve ser aplicado.");
                txtFrequency.BackColor = Color.LightSalmon;
                cbPrescribedProducts.BackColor = DefaultBackColor;
                txtDose.BackColor = DefaultBackColor;
                return false;
            }

            cbPrescribedProducts.BackColor = DefaultBackColor;
            txtDose.BackColor = DefaultBackColor;
            txtFrequency.BackColor = DefaultBackColor;
            return true;
        }

        private bool allFullfilledExamPrescription()
        {
            if (Convert.ToInt64(cbPrescribedExams.SelectedValue) == -1)
            {
                MessageBox.Show("É necessário selecionar um exame para prescreve-lo.");
                cbPrescribedExams.BackColor = Color.LightSalmon;
                return false;
            }

            cbPrescribedExams.BackColor = DefaultBackColor;
            return true;
        }

        private void dtScheduleDate_ValueChanged(object sender, EventArgs e)
        {

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
                var vetId = Convert.ToInt64(cbVet.SelectedValue);
                var ownerId = Convert.ToInt64(cbOwner.SelectedValue);
                var petId = Convert.ToInt64(cbPet.SelectedValue);

                Vet vet = (Vet)vetService.GetById(vetId);
                Owner owner = (Owner)ownerService.GetById(ownerId);
                Pet pet = (Pet)petService.GetById(petId);

                Composition.AddSlice<Owner, Pet>(owner, pet);

                List<ConsultationProduct> consultationProducts = new List<ConsultationProduct>();
                List<ConsultationExam> consultationExams = new List<ConsultationExam>();

                currentlyBeingRegistered = new MedicalConsultation(dtScheduleDate.Value, vetId, ownerId, petId, consultationProducts, consultationExams);

                medicalConsultationService.Insert(currentlyBeingRegistered);

                long? medicalConsultationId = medicalConsultationService.GetId(currentlyBeingRegistered);

                if (currentlyBeingPrescribedProducts != null)
                {
                    foreach (ConsultationProduct prescribedProduct in currentlyBeingPrescribedProducts)
                    {
                        ConsultationProduct newEntry = prescribedProduct;
                        newEntry.MedicalConsultationId = medicalConsultationId;
                        consultationProductService.Insert(newEntry);
                    }
                }

                if (currentlyBeingPrescribedExams != null)
                {
                    foreach (ConsultationExam prescribedExam in currentlyBeingPrescribedExams)
                    {
                        ConsultationExam newEntry = prescribedExam;
                        newEntry.MedicalConsultationId = medicalConsultationId;
                        consultationExamService.Insert(newEntry);
                    }
                }

                resetForm();

                refreshDataGridView();
                refreshDataGridViewPrescriptedExams();
                refreshDataGridViewPrescriptedProducts();
            }
        }

        private void txtAllTime_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            refreshDataGridViewMonthly();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            refreshDataGridViewDaily();
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            refreshDataGridViewWeekly();
        }

        private void MedicalConsultationSchedule_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("A caixa de Id não deve estar vazia, selecione uma consulta antes de alterar.");
                return;
            }
            else if (allFullfilled())
            {
                currentlyBeingRegistered = new MedicalConsultation();

                var vetId = Convert.ToInt64(cbVet.SelectedValue);
                var ownerId = Convert.ToInt64(cbOwner.SelectedValue);
                var petId = Convert.ToInt64(cbPet.SelectedValue);

                Vet vet = (Vet)vetService.GetById(vetId);
                Owner owner = (Owner)ownerService.GetById(ownerId);
                Pet pet = (Pet)petService.GetById(petId);

                long? medicalConsultationId = Convert.ToInt64(txtId.Text);

                Composition.AddSlice<Owner, Pet>(owner, pet);

                List<ConsultationProduct> consultationProducts = new List<ConsultationProduct>();
                List<ConsultationExam> consultationExams = new List<ConsultationExam>();

                currentlyBeingRegistered = new MedicalConsultation(dtScheduleDate.Value, vetId, ownerId, petId, consultationProducts, consultationExams)
                {
                    MedicalConsultationId = medicalConsultationId
                };

                if (currentlyBeingPrescribedProducts != null)
                {
                    foreach (ConsultationProduct prescribedProduct in currentlyBeingPrescribedProducts)
                    {
                        ConsultationProduct newEntry = prescribedProduct;
                        newEntry.MedicalConsultationId = medicalConsultationId;
                        //se já não estiver registrado
                        if (newEntry.ConsultationProductId == null)
                            consultationProductService.Insert(newEntry);
                    }
                }

                if (currentlyBeingPrescribedExams != null)
                {
                    foreach (ConsultationExam prescribedExam in currentlyBeingPrescribedExams)
                    {
                        ConsultationExam newEntry = prescribedExam;
                        newEntry.MedicalConsultationId = medicalConsultationId;
                        //se já não estiver registrado
                        if (newEntry.ConsultationExamId == null)
                            consultationExamService.Insert(newEntry);
                    }
                }

                medicalConsultationService.Alter(currentlyBeingRegistered);

                refreshDataGridView();
                refreshDataGridViewPrescriptedExams();
                refreshDataGridViewPrescriptedProducts();

                resetForm();
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
                medicalConsultationService.Remove(Convert.ToInt64(txtId.Text));
                refreshDataGridView();
                refreshDataGridViewPrescriptedExams();
                refreshDataGridViewPrescriptedProducts();
                resetForm();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtFrequency_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPrescribedProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrescribeProduct_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                MessageBox.Show("É necessário selecionar uma consulta já marcada para prescrever um remédio.");
                return;
            }
            if (allFullfilledProductPrescription())
            {
                Product product = productService.GetById(Convert.ToInt64(cbPrescribedProducts.SelectedValue));

                ConsultationProduct newEntry;

                if (!txtIdConsultationProduct.Text.Equals(String.Empty))
                {
                    newEntry = new ConsultationProduct(txtDose.Text, txtFrequency.Text, Convert.ToInt64(txtId.Text), product.ProductId)
                    {
                        ConsultationProductId = Convert.ToInt64(txtIdConsultationProduct.Text)
                    };
                }

                else
                {
                    newEntry = new ConsultationProduct(txtDose.Text, txtFrequency.Text, Convert.ToInt64(txtId.Text), product.ProductId);
                }

                consultationProductService.Insert(newEntry);

                refreshDataGridViewPrescriptedProducts();
            }
        }

        private void dgvPrescribedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnPrescribeExam_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                MessageBox.Show("É necessário selecionar uma consulta já marcada para prescrever um exame.");
                return;
            }
            if (allFullfilledExamPrescription())
            {
                Exam exam = examService.GetById(Convert.ToInt64(cbPrescribedExams.SelectedValue));

                ConsultationExam newEntry;

                if (!txtIdConsultationExam.Text.Equals(String.Empty))
                {
                    newEntry = new ConsultationExam(Convert.ToInt64(txtId.Text), exam.ExamId)
                    {
                        ConsultationExamId = Convert.ToInt64(txtIdConsultationExam.Text)
                    };
                }

                else
                {
                    newEntry = new ConsultationExam(Convert.ToInt64(txtId.Text), exam.ExamId);
                }

                consultationExamService.Insert(newEntry);

                refreshDataGridViewPrescriptedExams();
            }
        }

        private long? GetMedicalConsultationIdDgv(int rowIndex)
        {
            if (rowIndex >= 0)
                return Convert.ToInt32(dgvMedicalConsultation.Rows[rowIndex].Cells[0].Value);
            else
                return null;
        }

        private void loadMedicalConsultationData(MedicalConsultation medicalConsultation)
        {
            currentlyBeingPrescribedExams    = (List<ConsultationExam>)    consultationExamService.ShowAll(medicalConsultation);
            currentlyBeingPrescribedProducts = (List<ConsultationProduct>) consultationProductService.ShowAll(medicalConsultation);

            refreshDataGridViewPrescriptedExams();
            refreshDataGridViewPrescriptedProducts();

            txtId.Text = Convert.ToString(medicalConsultation.MedicalConsultationId).Trim();

            cbVet.SelectedValue = 0;
            cbVet.SelectedValue = medicalConsultation.VetId;

            cbOwner.SelectedValue = 0;
            cbOwner.SelectedValue = medicalConsultation.OwnerId;

            cbPet.SelectedValue = 0;
            cbPet.SelectedValue = medicalConsultation.PetId;
        }

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var medicalConsultationId = GetMedicalConsultationIdDgv(e.RowIndex);
                if (medicalConsultationId.Equals(null) || !(medicalConsultationId > 0))
                {
                    return;
                }
                var medicalConsultation = medicalConsultationService.GetById(Convert.ToInt64(medicalConsultationId));

                resetForm();

                loadMedicalConsultationData(medicalConsultation);

                refreshDataGridViewPrescriptedProducts();

                refreshDataGridViewPrescriptedExams();
                
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {

        }

        private void loadConsultationProductData(ConsultationProduct consultationProduct)
        {
            txtIdConsultationProduct.Text = Convert.ToString(consultationProduct.ConsultationProductId);
            cbPrescribedProducts.SelectedValue = Convert.ToInt64(consultationProduct.ProductId);
            txtDose.Text = consultationProduct.Dose;
            txtFrequency.Text = consultationProduct.Frequency;
        }

        private long getConsultationProductIdDgv(int rowIndex)
        {
            return Convert.ToInt32(dgvPrescribedProduct.Rows[rowIndex].Cells[0].Value);
        }

        private void dgvPrescribedProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                loadConsultationProductData(consultationProductService.GetById(getConsultationProductIdDgv(e.RowIndex)));
        }

        private void btnRemoveproduct_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo id deve estar preenchido para remover uma prescrição, selecione uma prescição e tente novamente.");
            }

            else if (allFullfilledProductPrescription())
            {
                consultationProductService.Remove(Convert.ToInt64(txtIdConsultationProduct.Text));
                resetFormPrescriptProduct();
                refreshDataGridViewPrescriptedProducts();
            }
        }

        private void dgvPrescribedExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                btnRemoveProduct.Enabled = false;
            }
            else
            {
                btnRemoveProduct.Enabled = true;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnResetProduct_Click(object sender, EventArgs e)
        {
            resetFormPrescriptProduct();
        }

        private void loadConsultationExamData(ConsultationExam consultationExam)
        {
            txtIdConsultationExam.Text = Convert.ToString(consultationExam.ConsultationExamId);
            cbPrescribedExams.SelectedValue = Convert.ToInt64(consultationExam.ExamId);
        }

        private long getConsultationExamIdDgv(int rowIndex)
        {
            return Convert.ToInt32(dgvPrescribedExam.Rows[rowIndex].Cells[0].Value);
        }

        private void dgvPrescribedExam_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                loadConsultationExamData(consultationExamService.GetById(getConsultationExamIdDgv(e.RowIndex)));
        }

        private void btnRemoveExam_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo id deve estar preenchido para remover uma prescrição, selecione uma prescrição e tente novamente.");
            }

            //só é necessário que o Id do registro a ser removido esteja na caixa de texto
            else
            {
                consultationExamService.Remove(Convert.ToInt64(txtIdConsultationExam.Text));
                resetFormPrescriptProduct();
                refreshDataGridViewPrescriptedProducts();
            }
        }

        private void btnResetExam_Click(object sender, EventArgs e)
        {
            resetFormPrescriptExam();
        }

        private void dgvMedicalConsultation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                btnAlter.Enabled = false;
                btnRemove.Enabled = false;

                cbPrescribedProducts.Enabled = false;
                txtDose.Enabled = false;
                txtFrequency.Enabled = false;
                btnPrescribeProduct.Enabled = false;
                btnRemoveProduct.Enabled = false;
                btnResetProduct.Enabled = false;

                cbPrescribedExams.Enabled = false;
                btnPrescribeExam.Enabled = false;
                btnRemoveExam.Enabled = false;
                btnResetExam.Enabled = false;
            }
            else
            {
                btnAlter.Enabled = true;
                btnRemove.Enabled = true;

                cbPrescribedProducts.Enabled = true;
                txtDose.Enabled = true;
                txtFrequency.Enabled = true;
                btnPrescribeProduct.Enabled = true;
                btnResetProduct.Enabled = true;

                cbPrescribedExams.Enabled = true;
                btnPrescribeExam.Enabled = true;
                btnResetExam.Enabled = true;
            }
        }

        private void txtIdConsultationExam_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(String.Empty))
            {
                btnRemoveExam.Enabled = false;
            }
            else
            {
                btnRemoveExam.Enabled = true;
            }
        }
    }
}
