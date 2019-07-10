namespace View
{
    partial class FormAdress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdress));
            this.btnReset = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOwner = new System.Windows.Forms.ComboBox();
            this.dgvAdress = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.InsBtn = new System.Windows.Forms.Button();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdress)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Image = global::View.Properties.Resources._5;
            this.btnReset.Location = new System.Drawing.Point(1020, 166);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 31);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(116, 36);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(85, 22);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Image = global::View.Properties.Resources._5;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adress Id:";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Image = global::View.Properties.Resources._5;
            this.btnRemove.Location = new System.Drawing.Point(1020, 129);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(138, 31);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Enabled = false;
            this.btnAlter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlter.Image = global::View.Properties.Resources._5;
            this.btnAlter.Location = new System.Drawing.Point(1020, 92);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(138, 31);
            this.btnAlter.TabIndex = 17;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = global::View.Properties.Resources._5;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Owner:";
            // 
            // cbOwner
            // 
            this.cbOwner.FormattingEnabled = true;
            this.cbOwner.Location = new System.Drawing.Point(116, 65);
            this.cbOwner.Name = "cbOwner";
            this.cbOwner.Size = new System.Drawing.Size(823, 24);
            this.cbOwner.TabIndex = 3;
            this.cbOwner.SelectedIndexChanged += new System.EventHandler(this.cbOwner_SelectedIndexChanged);
            this.cbOwner.SelectedValueChanged += new System.EventHandler(this.cbOwner_ValueMemberChanged);
            // 
            // dgvAdress
            // 
            this.dgvAdress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdress.Location = new System.Drawing.Point(12, 255);
            this.dgvAdress.Name = "dgvAdress";
            this.dgvAdress.RowTemplate.Height = 24;
            this.dgvAdress.Size = new System.Drawing.Size(1210, 258);
            this.dgvAdress.TabIndex = 21;
            this.dgvAdress.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdress_CellClick);
            this.dgvAdress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdress_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = global::View.Properties.Resources._5;
            this.label4.Location = new System.Drawing.Point(9, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Registros:";
            // 
            // InsBtn
            // 
            this.InsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsBtn.Image = global::View.Properties.Resources._5;
            this.InsBtn.Location = new System.Drawing.Point(1020, 55);
            this.InsBtn.Name = "InsBtn";
            this.InsBtn.Size = new System.Drawing.Size(138, 31);
            this.InsBtn.TabIndex = 16;
            this.InsBtn.Text = "Gravar";
            this.InsBtn.UseVisualStyleBackColor = true;
            this.InsBtn.Click += new System.EventHandler(this.InsBtn_Click);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(116, 118);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(320, 22);
            this.txtStreet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = global::View.Properties.Resources._5;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rua:";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(619, 113);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(320, 22);
            this.txtDetails.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = global::View.Properties.Resources._5;
            this.label3.Location = new System.Drawing.Point(515, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Complemento:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(619, 142);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(320, 22);
            this.txtCity.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Image = global::View.Properties.Resources._5;
            this.label8.Location = new System.Drawing.Point(515, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cidade:";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Location = new System.Drawing.Point(116, 146);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(320, 22);
            this.txtNeighborhood.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Image = global::View.Properties.Resources._5;
            this.label9.Location = new System.Drawing.Point(12, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Bairro:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(619, 170);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(320, 22);
            this.txtNumber.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Image = global::View.Properties.Resources._5;
            this.label10.Location = new System.Drawing.Point(515, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Número:";
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(116, 174);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(320, 22);
            this.txtPostal.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Image = global::View.Properties.Resources._5;
            this.label11.Location = new System.Drawing.Point(12, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "CEP:";
            // 
            // FormAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(1234, 526);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNeighborhood);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOwner);
            this.Controls.Add(this.dgvAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InsBtn);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdress";
            this.Load += new System.EventHandler(this.FormAdress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOwner;
        private System.Windows.Forms.DataGridView dgvAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InsBtn;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.Label label11;
    }
}