namespace View
{
    partial class FormCashflow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCashflow));
            this.dgvEarningPayment = new System.Windows.Forms.DataGridView();
            this.dgvSaleStorage = new System.Windows.Forms.DataGridView();
            this.dgvCashflow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductExam = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnEarning = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnPaid = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEarningPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashflow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductExam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEarningPayment
            // 
            this.dgvEarningPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEarningPayment.Location = new System.Drawing.Point(73, 394);
            this.dgvEarningPayment.Name = "dgvEarningPayment";
            this.dgvEarningPayment.RowTemplate.Height = 24;
            this.dgvEarningPayment.Size = new System.Drawing.Size(331, 351);
            this.dgvEarningPayment.TabIndex = 12;
            // 
            // dgvSaleStorage
            // 
            this.dgvSaleStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleStorage.Location = new System.Drawing.Point(425, 394);
            this.dgvSaleStorage.Name = "dgvSaleStorage";
            this.dgvSaleStorage.RowTemplate.Height = 24;
            this.dgvSaleStorage.Size = new System.Drawing.Size(331, 351);
            this.dgvSaleStorage.TabIndex = 14;
            // 
            // dgvCashflow
            // 
            this.dgvCashflow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashflow.Location = new System.Drawing.Point(387, 64);
            this.dgvCashflow.Name = "dgvCashflow";
            this.dgvCashflow.RowTemplate.Height = 24;
            this.dgvCashflow.Size = new System.Drawing.Size(752, 274);
            this.dgvCashflow.TabIndex = 10;
            this.dgvCashflow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCashflow_CellClick);
            this.dgvCashflow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCashflow_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = global::View.Properties.Resources._5;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(422, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Venda/compra associada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = global::View.Properties.Resources._5;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(70, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Entrada/saída:";
            // 
            // dgvProductExam
            // 
            this.dgvProductExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductExam.Location = new System.Drawing.Point(777, 394);
            this.dgvProductExam.Name = "dgvProductExam";
            this.dgvProductExam.RowTemplate.Height = 24;
            this.dgvProductExam.Size = new System.Drawing.Size(331, 351);
            this.dgvProductExam.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = global::View.Properties.Resources._5;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(774, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Produtos/serviços envolvidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = global::View.Properties.Resources._5;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(384, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Caixa:";
            // 
            // btnAll
            // 
            this.btnAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAll.Image = global::View.Properties.Resources._5;
            this.btnAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAll.Location = new System.Drawing.Point(56, 132);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(114, 31);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "Todos";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPayment.Image = global::View.Properties.Resources._5;
            this.btnPayment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPayment.Location = new System.Drawing.Point(56, 206);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(114, 31);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Saídas";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnEarning
            // 
            this.btnEarning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEarning.Image = global::View.Properties.Resources._5;
            this.btnEarning.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEarning.Location = new System.Drawing.Point(56, 169);
            this.btnEarning.Name = "btnEarning";
            this.btnEarning.Size = new System.Drawing.Size(114, 31);
            this.btnEarning.TabIndex = 3;
            this.btnEarning.Text = "Entradas";
            this.btnEarning.UseVisualStyleBackColor = true;
            this.btnEarning.Click += new System.EventHandler(this.btnEarning_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackgroundImage = global::View.Properties.Resources._5;
            this.btnPay.Enabled = false;
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPay.Image = global::View.Properties.Resources._5;
            this.btnPay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPay.Location = new System.Drawing.Point(66, 294);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(114, 31);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pagar";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnPaid
            // 
            this.btnPaid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPaid.Image = global::View.Properties.Resources._5;
            this.btnPaid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPaid.Location = new System.Drawing.Point(212, 151);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(114, 31);
            this.btnPaid.TabIndex = 5;
            this.btnPaid.Text = "Pagas";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // btnPending
            // 
            this.btnPending.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPending.Image = global::View.Properties.Resources._5;
            this.btnPending.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPending.Location = new System.Drawing.Point(212, 188);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(114, 31);
            this.btnPending.TabIndex = 6;
            this.btnPending.Text = "Pendentes";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(186, 298);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(128, 22);
            this.txtId.TabIndex = 8;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(212, 64);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(128, 22);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Image = global::View.Properties.Resources._5;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(106, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total em caixa:";
            // 
            // FormCashflow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(1195, 757);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnEarning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProductExam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCashflow);
            this.Controls.Add(this.dgvSaleStorage);
            this.Controls.Add(this.dgvEarningPayment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCashflow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCashflow";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEarningPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashflow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEarningPayment;
        private System.Windows.Forms.DataGridView dgvSaleStorage;
        private System.Windows.Forms.DataGridView dgvCashflow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductExam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnEarning;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
    }
}