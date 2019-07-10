using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPet formPet = new FormPet();
            formPet.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDrug formPetDrug = new FormDrug();
            formPetDrug.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormOwner formOwner = new FormOwner();
            formOwner.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormExam formExam = new FormExam();
            formExam.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormVet formVet = new FormVet();
            formVet.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormMedicalConsultation medicalConsultationSchedule = new FormMedicalConsultation();
            medicalConsultationSchedule.Show();
        }

        private void btnEarning_Click(object sender, EventArgs e)
        {
            FormSale formSale = new FormSale();
            formSale.Show();
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            FormStorage formStorage = new FormStorage();
            formStorage.Show();
        }

        private void btnCashflow_Click(object sender, EventArgs e)
        {
            FormCashflow formCashflow = new FormCashflow();
            formCashflow.Show();
        }
    }
}
