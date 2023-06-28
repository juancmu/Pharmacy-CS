namespace Act2Pharmacy
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtNameMedicament = new System.Windows.Forms.TextBox();
            this.cmbBoxNameMedicament = new System.Windows.Forms.ComboBox();
            this.txtQtyMedicament = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rBtnCofarma = new System.Windows.Forms.RadioButton();
            this.rBtnEmpsephar = new System.Windows.Forms.RadioButton();
            this.rBtnCemefar = new System.Windows.Forms.RadioButton();
            this.groupBoxVendor = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBoxSecondVendor = new System.Windows.Forms.CheckBox();
            this.chkBoxMainVendor = new System.Windows.Forms.CheckBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.error3 = new System.Windows.Forms.Label();
            this.error4 = new System.Windows.Forms.Label();
            this.error5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxVendor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameMedicament
            // 
            this.txtNameMedicament.Location = new System.Drawing.Point(185, 79);
            this.txtNameMedicament.Name = "txtNameMedicament";
            this.txtNameMedicament.Size = new System.Drawing.Size(279, 20);
            this.txtNameMedicament.TabIndex = 0;
            // 
            // cmbBoxNameMedicament
            // 
            this.cmbBoxNameMedicament.FormattingEnabled = true;
            this.cmbBoxNameMedicament.Items.AddRange(new object[] {
            "ANALGESICO",
            "ANALEPTICO",
            "ANESTESICO",
            "ANTIACIDO",
            "ANTIDEPRESIVO",
            "ANTIBIOTICO"});
            this.cmbBoxNameMedicament.Location = new System.Drawing.Point(185, 140);
            this.cmbBoxNameMedicament.Name = "cmbBoxNameMedicament";
            this.cmbBoxNameMedicament.Size = new System.Drawing.Size(205, 21);
            this.cmbBoxNameMedicament.TabIndex = 1;
            // 
            // txtQtyMedicament
            // 
            this.txtQtyMedicament.Location = new System.Drawing.Point(185, 198);
            this.txtQtyMedicament.Name = "txtQtyMedicament";
            this.txtQtyMedicament.Size = new System.Drawing.Size(107, 20);
            this.txtQtyMedicament.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONE EL MEDICAMENTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del \r\nMedicamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de\r\nMedicamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad del\r\nMedicamento";
            // 
            // rBtnCofarma
            // 
            this.rBtnCofarma.AutoSize = true;
            this.rBtnCofarma.Location = new System.Drawing.Point(18, 26);
            this.rBtnCofarma.Name = "rBtnCofarma";
            this.rBtnCofarma.Size = new System.Drawing.Size(120, 24);
            this.rBtnCofarma.TabIndex = 8;
            this.rBtnCofarma.TabStop = true;
            this.rBtnCofarma.Text = "COFARMA";
            this.rBtnCofarma.UseVisualStyleBackColor = true;
            // 
            // rBtnEmpsephar
            // 
            this.rBtnEmpsephar.AutoSize = true;
            this.rBtnEmpsephar.Location = new System.Drawing.Point(176, 26);
            this.rBtnEmpsephar.Name = "rBtnEmpsephar";
            this.rBtnEmpsephar.Size = new System.Drawing.Size(144, 24);
            this.rBtnEmpsephar.TabIndex = 9;
            this.rBtnEmpsephar.TabStop = true;
            this.rBtnEmpsephar.Text = "EMPSEPHAR";
            this.rBtnEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rBtnCemefar
            // 
            this.rBtnCemefar.AutoSize = true;
            this.rBtnCemefar.Location = new System.Drawing.Point(344, 26);
            this.rBtnCemefar.Name = "rBtnCemefar";
            this.rBtnCemefar.Size = new System.Drawing.Size(118, 24);
            this.rBtnCemefar.TabIndex = 10;
            this.rBtnCemefar.TabStop = true;
            this.rBtnCemefar.Text = "CEMEFAR";
            this.rBtnCemefar.UseVisualStyleBackColor = true;
            // 
            // groupBoxVendor
            // 
            this.groupBoxVendor.Controls.Add(this.rBtnCemefar);
            this.groupBoxVendor.Controls.Add(this.rBtnCofarma);
            this.groupBoxVendor.Controls.Add(this.rBtnEmpsephar);
            this.groupBoxVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVendor.Location = new System.Drawing.Point(19, 238);
            this.groupBoxVendor.Name = "groupBoxVendor";
            this.groupBoxVendor.Size = new System.Drawing.Size(502, 69);
            this.groupBoxVendor.TabIndex = 11;
            this.groupBoxVendor.TabStop = false;
            this.groupBoxVendor.Text = "Distribuidor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBoxSecondVendor);
            this.groupBox2.Controls.Add(this.chkBoxMainVendor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 54);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Surcursal de Envio";
            // 
            // chkBoxSecondVendor
            // 
            this.chkBoxSecondVendor.AutoSize = true;
            this.chkBoxSecondVendor.Location = new System.Drawing.Point(231, 24);
            this.chkBoxSecondVendor.Name = "chkBoxSecondVendor";
            this.chkBoxSecondVendor.Size = new System.Drawing.Size(150, 24);
            this.chkBoxSecondVendor.TabIndex = 1;
            this.chkBoxSecondVendor.Text = "SECUNDARIA";
            this.chkBoxSecondVendor.UseVisualStyleBackColor = true;
            // 
            // chkBoxMainVendor
            // 
            this.chkBoxMainVendor.AutoSize = true;
            this.chkBoxMainVendor.Location = new System.Drawing.Point(52, 22);
            this.chkBoxMainVendor.Name = "chkBoxMainVendor";
            this.chkBoxMainVendor.Size = new System.Drawing.Size(127, 24);
            this.chkBoxMainVendor.TabIndex = 0;
            this.chkBoxMainVendor.Text = "PRINCIPAL";
            this.chkBoxMainVendor.UseVisualStyleBackColor = true;
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.Location = new System.Drawing.Point(82, 389);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(210, 49);
            this.btnErase.TabIndex = 13;
            this.btnErase.Text = "BORRAR";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(471, 389);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(210, 49);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "CONFIRMAR";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // error1
            // 
            this.error1.Location = new System.Drawing.Point(508, 80);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(253, 28);
            this.error1.TabIndex = 15;
            // 
            // error2
            // 
            this.error2.Location = new System.Drawing.Point(508, 140);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(253, 28);
            this.error2.TabIndex = 16;
            // 
            // error3
            // 
            this.error3.Location = new System.Drawing.Point(314, 198);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(451, 28);
            this.error3.TabIndex = 17;
            // 
            // error4
            // 
            this.error4.Location = new System.Drawing.Point(535, 264);
            this.error4.Name = "error4";
            this.error4.Size = new System.Drawing.Size(253, 28);
            this.error4.TabIndex = 18;
            // 
            // error5
            // 
            this.error5.Location = new System.Drawing.Point(535, 334);
            this.error5.Name = "error5";
            this.error5.Size = new System.Drawing.Size(253, 28);
            this.error5.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error5);
            this.Controls.Add(this.error4);
            this.Controls.Add(this.error3);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxVendor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtyMedicament);
            this.Controls.Add(this.cmbBoxNameMedicament);
            this.Controls.Add(this.txtNameMedicament);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ACTIVIDAD 2 PLATAFORMAS DE DESARROLLO DE SOFTWARE - ESTUDIANTE: JUAN CARLOS MUNOZ" +
    "";
            this.groupBoxVendor.ResumeLayout(false);
            this.groupBoxVendor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameMedicament;
        private System.Windows.Forms.ComboBox cmbBoxNameMedicament;
        private System.Windows.Forms.TextBox txtQtyMedicament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rBtnCofarma;
        private System.Windows.Forms.RadioButton rBtnEmpsephar;
        private System.Windows.Forms.RadioButton rBtnCemefar;
        private System.Windows.Forms.GroupBox groupBoxVendor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBoxSecondVendor;
        private System.Windows.Forms.CheckBox chkBoxMainVendor;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.Label error4;
        private System.Windows.Forms.Label error5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

