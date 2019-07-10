namespace View
{
    partial class FormMedicalConsultation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicalConsultation));
            this.btnPrescribeExam = new System.Windows.Forms.Button();
            this.btnPrescribeProduct = new System.Windows.Forms.Button();
            this.dgvPrescribedExam = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPrescribedProduct = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvMedicalConsultation = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtScheduleDate = new System.Windows.Forms.DateTimePicker();
            this.cbVet = new System.Windows.Forms.ComboBox();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnDaily = new System.Windows.Forms.Button();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.cbOwner = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAllTime = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.cbPrescribedProducts = new System.Windows.Forms.ComboBox();
            this.cbPrescribedExams = new System.Windows.Forms.ComboBox();
            this.txtDose = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnRemoveExam = new System.Windows.Forms.Button();
            this.txtIdConsultationProduct = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdConsultationExam = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnResetProduct = new System.Windows.Forms.Button();
            this.btnResetExam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescribedExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescribedProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalConsultation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrescribeExam
            // 
            this.btnPrescribeExam.Enabled = false;
            this.btnPrescribeExam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrescribeExam.Image = ((System.Drawing.Image)(resources.GetObject("btnPrescribeExam.Image")));
            this.btnPrescribeExam.Location = new System.Drawing.Point(1046, 530);
            this.btnPrescribeExam.Name = "btnPrescribeExam";
            this.btnPrescribeExam.Size = new System.Drawing.Size(153, 27);
            this.btnPrescribeExam.TabIndex = 40;
            this.btnPrescribeExam.Text = "Prescrever";
            this.btnPrescribeExam.UseVisualStyleBackColor = true;
            this.btnPrescribeExam.Click += new System.EventHandler(this.btnPrescribeExam_Click);
            // 
            // btnPrescribeProduct
            // 
            this.btnPrescribeProduct.Enabled = false;
            this.btnPrescribeProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrescribeProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnPrescribeProduct.Image")));
            this.btnPrescribeProduct.Location = new System.Drawing.Point(1106, 206);
            this.btnPrescribeProduct.Name = "btnPrescribeProduct";
            this.btnPrescribeProduct.Size = new System.Drawing.Size(92, 28);
            this.btnPrescribeProduct.TabIndex = 31;
            this.btnPrescribeProduct.Text = "Prescrever";
            this.btnPrescribeProduct.UseVisualStyleBackColor = true;
            this.btnPrescribeProduct.Click += new System.EventHandler(this.btnPrescribeProduct_Click);
            // 
            // dgvPrescribedExam
            // 
            this.dgvPrescribedExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescribedExam.Location = new System.Drawing.Point(719, 348);
            this.dgvPrescribedExam.Name = "dgvPrescribedExam";
            this.dgvPrescribedExam.RowTemplate.Height = 24;
            this.dgvPrescribedExam.Size = new System.Drawing.Size(475, 176);
            this.dgvPrescribedExam.TabIndex = 35;
            this.dgvPrescribedExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrescribedExam_CellClick_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(12, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Agenda de consultas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(716, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Exames prescritos:";
            // 
            // dgvPrescribedProduct
            // 
            this.dgvPrescribedProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescribedProduct.Location = new System.Drawing.Point(724, 41);
            this.dgvPrescribedProduct.Name = "dgvPrescribedProduct";
            this.dgvPrescribedProduct.RowTemplate.Height = 24;
            this.dgvPrescribedProduct.Size = new System.Drawing.Size(475, 154);
            this.dgvPrescribedProduct.TabIndex = 22;
            this.dgvPrescribedProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrescribedProduct_CellClick);
            this.dgvPrescribedProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrescribedProducts_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Image = global::View.Properties.Resources._5;
            this.label9.Location = new System.Drawing.Point(721, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Remédios prescritos:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(111, 18);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(93, 22);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id:";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(396, 221);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 31);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(156, 221);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 31);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvMedicalConsultation
            // 
            this.dgvMedicalConsultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalConsultation.Location = new System.Drawing.Point(15, 348);
            this.dgvMedicalConsultation.Name = "dgvMedicalConsultation";
            this.dgvMedicalConsultation.RowTemplate.Height = 24;
            this.dgvMedicalConsultation.Size = new System.Drawing.Size(665, 274);
            this.dgvMedicalConsultation.TabIndex = 20;
            this.dgvMedicalConsultation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellClick);
            this.dgvMedicalConsultation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicalConsultation_CellContentClick);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(276, 221);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(114, 31);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Gravar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Veterinário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marcar para: ";
            // 
            // dtScheduleDate
            // 
            this.dtScheduleDate.Location = new System.Drawing.Point(111, 90);
            this.dtScheduleDate.Name = "dtScheduleDate";
            this.dtScheduleDate.Size = new System.Drawing.Size(569, 22);
            this.dtScheduleDate.TabIndex = 4;
            this.dtScheduleDate.ValueChanged += new System.EventHandler(this.dtScheduleDate_ValueChanged);
            // 
            // cbVet
            // 
            this.cbVet.FormattingEnabled = true;
            this.cbVet.Location = new System.Drawing.Point(111, 119);
            this.cbVet.Name = "cbVet";
            this.cbVet.Size = new System.Drawing.Size(569, 24);
            this.cbVet.TabIndex = 6;
            // 
            // btnMonthly
            // 
            this.btnMonthly.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMonthly.Image = ((System.Drawing.Image)(resources.GetObject("btnMonthly.Image")));
            this.btnMonthly.Location = new System.Drawing.Point(396, 296);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(114, 31);
            this.btnMonthly.TabIndex = 18;
            this.btnMonthly.Text = "Mensal";
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnDaily
            // 
            this.btnDaily.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDaily.Image = ((System.Drawing.Image)(resources.GetObject("btnDaily.Image")));
            this.btnDaily.Location = new System.Drawing.Point(156, 296);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(114, 31);
            this.btnDaily.TabIndex = 16;
            this.btnDaily.Text = "Diário";
            this.btnDaily.UseVisualStyleBackColor = true;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // btnWeekly
            // 
            this.btnWeekly.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWeekly.Image = ((System.Drawing.Image)(resources.GetObject("btnWeekly.Image")));
            this.btnWeekly.Location = new System.Drawing.Point(276, 296);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(114, 31);
            this.btnWeekly.TabIndex = 17;
            this.btnWeekly.Text = "Semanal";
            this.btnWeekly.UseVisualStyleBackColor = true;
            this.btnWeekly.Click += new System.EventHandler(this.btnWeekly_Click);
            // 
            // cbOwner
            // 
            this.cbOwner.FormattingEnabled = true;
            this.cbOwner.Location = new System.Drawing.Point(111, 149);
            this.cbOwner.Name = "cbOwner";
            this.cbOwner.Size = new System.Drawing.Size(569, 24);
            this.cbOwner.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dono:";
            // 
            // cbPet
            // 
            this.cbPet.FormattingEnabled = true;
            this.cbPet.Location = new System.Drawing.Point(111, 179);
            this.cbPet.Name = "cbPet";
            this.cbPet.Size = new System.Drawing.Size(569, 24);
            this.cbPet.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pet:";
            // 
            // txtAllTime
            // 
            this.txtAllTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAllTime.Image = ((System.Drawing.Image)(resources.GetObject("txtAllTime.Image")));
            this.txtAllTime.Location = new System.Drawing.Point(516, 296);
            this.txtAllTime.Name = "txtAllTime";
            this.txtAllTime.Size = new System.Drawing.Size(114, 31);
            this.txtAllTime.TabIndex = 19;
            this.txtAllTime.Text = "Todas";
            this.txtAllTime.UseVisualStyleBackColor = true;
            this.txtAllTime.Click += new System.EventHandler(this.txtAllTime_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Agendamento de consultas:";
            // 
            // btnAlter
            // 
            this.btnAlter.Enabled = false;
            this.btnAlter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlter.Image = ((System.Drawing.Image)(resources.GetObject("btnAlter.Image")));
            this.btnAlter.Location = new System.Drawing.Point(516, 221);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(114, 31);
            this.btnAlter.TabIndex = 14;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // cbPrescribedProducts
            // 
            this.cbPrescribedProducts.Enabled = false;
            this.cbPrescribedProducts.FormattingEnabled = true;
            this.cbPrescribedProducts.Location = new System.Drawing.Point(878, 228);
            this.cbPrescribedProducts.Name = "cbPrescribedProducts";
            this.cbPrescribedProducts.Size = new System.Drawing.Size(222, 24);
            this.cbPrescribedProducts.TabIndex = 26;
            this.cbPrescribedProducts.SelectedIndexChanged += new System.EventHandler(this.cbPrescribedProduct_SelectedIndexChanged);
            // 
            // cbPrescribedExams
            // 
            this.cbPrescribedExams.Enabled = false;
            this.cbPrescribedExams.FormattingEnabled = true;
            this.cbPrescribedExams.Location = new System.Drawing.Point(785, 563);
            this.cbPrescribedExams.Name = "cbPrescribedExams";
            this.cbPrescribedExams.Size = new System.Drawing.Size(229, 24);
            this.cbPrescribedExams.TabIndex = 39;
            // 
            // txtDose
            // 
            this.txtDose.Enabled = false;
            this.txtDose.Location = new System.Drawing.Point(878, 258);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(222, 22);
            this.txtDose.TabIndex = 28;
            this.txtDose.TextChanged += new System.EventHandler(this.txtFrequency_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(725, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Remédio:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(725, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Dosagem:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(725, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Frequência e período:";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Enabled = false;
            this.txtFrequency.Location = new System.Drawing.Point(878, 287);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(222, 22);
            this.txtFrequency.TabIndex = 30;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Enabled = false;
            this.btnRemoveProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveProduct.Image")));
            this.btnRemoveProduct.Location = new System.Drawing.Point(1106, 240);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(92, 28);
            this.btnRemoveProduct.TabIndex = 32;
            this.btnRemoveProduct.Text = "Remover";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveproduct_Click_1);
            // 
            // btnRemoveExam
            // 
            this.btnRemoveExam.Enabled = false;
            this.btnRemoveExam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveExam.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveExam.Image")));
            this.btnRemoveExam.Location = new System.Drawing.Point(1046, 563);
            this.btnRemoveExam.Name = "btnRemoveExam";
            this.btnRemoveExam.Size = new System.Drawing.Size(153, 27);
            this.btnRemoveExam.TabIndex = 41;
            this.btnRemoveExam.Text = "Remover";
            this.btnRemoveExam.UseVisualStyleBackColor = true;
            this.btnRemoveExam.Click += new System.EventHandler(this.btnRemoveExam_Click);
            // 
            // txtIdConsultationProduct
            // 
            this.txtIdConsultationProduct.Enabled = false;
            this.txtIdConsultationProduct.Location = new System.Drawing.Point(878, 201);
            this.txtIdConsultationProduct.Name = "txtIdConsultationProduct";
            this.txtIdConsultationProduct.ReadOnly = true;
            this.txtIdConsultationProduct.Size = new System.Drawing.Size(93, 22);
            this.txtIdConsultationProduct.TabIndex = 24;
            this.txtIdConsultationProduct.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(725, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Id:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtIdConsultationExam
            // 
            this.txtIdConsultationExam.Enabled = false;
            this.txtIdConsultationExam.Location = new System.Drawing.Point(785, 535);
            this.txtIdConsultationExam.Name = "txtIdConsultationExam";
            this.txtIdConsultationExam.ReadOnly = true;
            this.txtIdConsultationExam.Size = new System.Drawing.Size(93, 22);
            this.txtIdConsultationExam.TabIndex = 37;
            this.txtIdConsultationExam.TextChanged += new System.EventHandler(this.txtIdConsultationExam_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(725, 535);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Id:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.Location = new System.Drawing.Point(725, 566);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "Exame:";
            // 
            // btnResetProduct
            // 
            this.btnResetProduct.Enabled = false;
            this.btnResetProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResetProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnResetProduct.Image")));
            this.btnResetProduct.Location = new System.Drawing.Point(1107, 274);
            this.btnResetProduct.Name = "btnResetProduct";
            this.btnResetProduct.Size = new System.Drawing.Size(92, 28);
            this.btnResetProduct.TabIndex = 33;
            this.btnResetProduct.Text = "Reset";
            this.btnResetProduct.UseVisualStyleBackColor = true;
            this.btnResetProduct.Click += new System.EventHandler(this.btnResetProduct_Click);
            // 
            // btnResetExam
            // 
            this.btnResetExam.Enabled = false;
            this.btnResetExam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResetExam.Image = ((System.Drawing.Image)(resources.GetObject("btnResetExam.Image")));
            this.btnResetExam.Location = new System.Drawing.Point(1046, 595);
            this.btnResetExam.Name = "btnResetExam";
            this.btnResetExam.Size = new System.Drawing.Size(153, 27);
            this.btnResetExam.TabIndex = 42;
            this.btnResetExam.Text = "Reset";
            this.btnResetExam.UseVisualStyleBackColor = true;
            this.btnResetExam.Click += new System.EventHandler(this.btnResetExam_Click);
            // 
            // FormMedicalConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(1207, 637);
            this.Controls.Add(this.btnResetExam);
            this.Controls.Add(this.btnResetProduct);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtIdConsultationExam);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtIdConsultationProduct);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnRemoveExam);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDose);
            this.Controls.Add(this.cbPrescribedExams);
            this.Controls.Add(this.cbPrescribedProducts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAllTime);
            this.Controls.Add(this.cbPet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbOwner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnDaily);
            this.Controls.Add(this.btnWeekly);
            this.Controls.Add(this.cbVet);
            this.Controls.Add(this.dtScheduleDate);
            this.Controls.Add(this.btnPrescribeExam);
            this.Controls.Add(this.btnPrescribeProduct);
            this.Controls.Add(this.dgvPrescribedExam);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvPrescribedProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvMedicalConsultation);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMedicalConsultation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalConsultationSchedule";
            this.Load += new System.EventHandler(this.MedicalConsultationSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescribedExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescribedProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalConsultation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrescribeExam;
        private System.Windows.Forms.Button btnPrescribeProduct;
        private System.Windows.Forms.DataGridView dgvPrescribedExam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvPrescribedProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvMedicalConsultation;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtScheduleDate;
        private System.Windows.Forms.ComboBox cbVet;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Button btnWeekly;
        private System.Windows.Forms.ComboBox cbOwner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtAllTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.ComboBox cbPrescribedProducts;
        private System.Windows.Forms.ComboBox cbPrescribedExams;
        private System.Windows.Forms.TextBox txtDose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnRemoveExam;
        private System.Windows.Forms.TextBox txtIdConsultationProduct;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdConsultationExam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnResetProduct;
        private System.Windows.Forms.Button btnResetExam;
    }
}