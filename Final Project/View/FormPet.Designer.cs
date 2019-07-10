namespace View
{
    partial class FormPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPet));
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InsBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.cbOwner = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvPrescriptedDrugs = new System.Windows.Forms.DataGridView();
            this.dgvMedicalConsultations = new System.Windows.Forms.DataGridView();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptedDrugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalConsultations)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(835, 22);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nascimento:";
            // 
            // InsBtn
            // 
            this.InsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InsBtn.BackgroundImage")));
            this.InsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsBtn.Image = ((System.Drawing.Image)(resources.GetObject("InsBtn.Image")));
            this.InsBtn.Location = new System.Drawing.Point(1058, 14);
            this.InsBtn.Name = "InsBtn";
            this.InsBtn.Size = new System.Drawing.Size(138, 31);
            this.InsBtn.TabIndex = 10;
            this.InsBtn.Text = "Gravar";
            this.InsBtn.UseVisualStyleBackColor = true;
            this.InsBtn.Click += new System.EventHandler(this.InsBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(21, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Registros:";
            // 
            // dgvPets
            // 
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Location = new System.Drawing.Point(12, 204);
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.RowTemplate.Height = 24;
            this.dgvPets.Size = new System.Drawing.Size(433, 314);
            this.dgvPets.TabIndex = 15;
            this.dgvPets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPets_CellClick);
            this.dgvPets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvPets.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPets_CellEnter);
            // 
            // cbOwner
            // 
            this.cbOwner.FormattingEnabled = true;
            this.cbOwner.Location = new System.Drawing.Point(113, 40);
            this.cbOwner.Name = "cbOwner";
            this.cbOwner.Size = new System.Drawing.Size(835, 24);
            this.cbOwner.TabIndex = 3;
            this.cbOwner.SelectedIndexChanged += new System.EventHandler(this.cbOwner_ValueMemberChanged);
            this.cbOwner.SelectionChangeCommitted += new System.EventHandler(this.cbOwner_SelectedIndexChanged);
            this.cbOwner.TextUpdate += new System.EventHandler(this.cbOwner_SelectedIndexChanged);
            this.cbOwner.ValueMemberChanged += new System.EventHandler(this.cbOwner_ValueMemberChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Owner:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.Enabled = false;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(1058, 88);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(138, 31);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(21, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pet Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(113, 11);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(97, 22);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged_1);
            // 
            // btnAlter
            // 
            this.btnAlter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlter.BackgroundImage")));
            this.btnAlter.Enabled = false;
            this.btnAlter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlter.Image = ((System.Drawing.Image)(resources.GetObject("btnAlter.Image")));
            this.btnAlter.Location = new System.Drawing.Point(1058, 51);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(138, 31);
            this.btnAlter.TabIndex = 11;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(1058, 125);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 31);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvPrescriptedDrugs
            // 
            this.dgvPrescriptedDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptedDrugs.Location = new System.Drawing.Point(451, 204);
            this.dgvPrescriptedDrugs.Name = "dgvPrescriptedDrugs";
            this.dgvPrescriptedDrugs.RowTemplate.Height = 24;
            this.dgvPrescriptedDrugs.Size = new System.Drawing.Size(433, 314);
            this.dgvPrescriptedDrugs.TabIndex = 17;
            // 
            // dgvMedicalConsultations
            // 
            this.dgvMedicalConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalConsultations.Location = new System.Drawing.Point(890, 204);
            this.dgvMedicalConsultations.Name = "dgvMedicalConsultations";
            this.dgvMedicalConsultations.RowTemplate.Height = 24;
            this.dgvMedicalConsultations.Size = new System.Drawing.Size(433, 314);
            this.dgvMedicalConsultations.TabIndex = 19;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(113, 104);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(835, 22);
            this.dtBirthday.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(451, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Remédios prescritos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(890, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Histórico de consultas:";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(113, 134);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(835, 22);
            this.txtSpecies.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(21, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Espécie:";
            // 
            // FormPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(1336, 530);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.dgvMedicalConsultations);
            this.Controls.Add(this.dgvPrescriptedDrugs);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOwner);
            this.Controls.Add(this.dgvPets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPet";
            this.Load += new System.EventHandler(this.FormPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptedDrugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalConsultations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InsBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.ComboBox cbOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvPrescriptedDrugs;
        private System.Windows.Forms.DataGridView dgvMedicalConsultations;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.Label label8;
    }
}