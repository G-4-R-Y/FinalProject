namespace View
{
    partial class FormVet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVet));
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAdress = new System.Windows.Forms.Button();
            this.dgvConsult = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvAdress = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvVet = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCRMV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(101, 206);
            this.txtCel.Mask = "(99) 00000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(576, 22);
            this.txtCel.TabIndex = 14;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(101, 177);
            this.txtTel.Mask = "(99) 0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(576, 22);
            this.txtTel.TabIndex = 12;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(101, 121);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(576, 22);
            this.txtCPF.TabIndex = 8;
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(101, 234);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(576, 22);
            this.dtBirth.TabIndex = 16;
            // 
            // btnAdress
            // 
            this.btnAdress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdress.Image = ((System.Drawing.Image)(resources.GetObject("btnAdress.Image")));
            this.btnAdress.Location = new System.Drawing.Point(1017, 261);
            this.btnAdress.Name = "btnAdress";
            this.btnAdress.Size = new System.Drawing.Size(174, 31);
            this.btnAdress.TabIndex = 25;
            this.btnAdress.Text = "Registro de endereços";
            this.btnAdress.UseVisualStyleBackColor = true;
            this.btnAdress.Click += new System.EventHandler(this.btnAdress_Click);
            // 
            // dgvConsult
            // 
            this.dgvConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsult.Location = new System.Drawing.Point(716, 351);
            this.dgvConsult.Name = "dgvConsult";
            this.dgvConsult.RowTemplate.Height = 24;
            this.dgvConsult.Size = new System.Drawing.Size(475, 274);
            this.dgvConsult.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(13, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Veterinários cadastrados:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(713, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Histórico de consultas:";
            // 
            // dgvAdress
            // 
            this.dgvAdress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdress.Location = new System.Drawing.Point(716, 36);
            this.dgvAdress.Name = "dgvAdress";
            this.dgvAdress.RowTemplate.Height = 24;
            this.dgvAdress.Size = new System.Drawing.Size(475, 219);
            this.dgvAdress.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Image = global::View.Properties.Resources._5;
            this.label9.Location = new System.Drawing.Point(713, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Endereços:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(19, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Informações básicas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(9, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(9, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(9, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(101, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(576, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(101, 12);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(9, 17);
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
            this.btnRemove.Location = new System.Drawing.Point(267, 277);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 31);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Enabled = false;
            this.btnAlter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlter.Image = ((System.Drawing.Image)(resources.GetObject("btnAlter.Image")));
            this.btnAlter.Location = new System.Drawing.Point(387, 277);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(114, 31);
            this.btnAlter.TabIndex = 20;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(27, 277);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 31);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvVet
            // 
            this.dgvVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVet.Location = new System.Drawing.Point(12, 351);
            this.dgvVet.Name = "dgvVet";
            this.dgvVet.RowTemplate.Height = 24;
            this.dgvVet.Size = new System.Drawing.Size(665, 274);
            this.dgvVet.TabIndex = 22;
            this.dgvVet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOwner_CellClick);
            this.dgvVet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVet_CellContentClick);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.Location = new System.Drawing.Point(147, 277);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(114, 31);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Gravar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(9, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(576, 22);
            this.txtName.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(9, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "CRMV:";
            // 
            // txtCRMV
            // 
            this.txtCRMV.Location = new System.Drawing.Point(101, 93);
            this.txtCRMV.Name = "txtCRMV";
            this.txtCRMV.Size = new System.Drawing.Size(576, 22);
            this.txtCRMV.TabIndex = 6;
            // 
            // FormVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(1207, 637);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCRMV);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.btnAdress);
            this.Controls.Add(this.dgvConsult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvAdress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvVet);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Button btnAdress;
        private System.Windows.Forms.DataGridView dgvConsult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvAdress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvVet;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCRMV;
    }
}