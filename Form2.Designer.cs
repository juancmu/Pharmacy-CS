namespace Act2Pharmacy
{
    partial class Confirm_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedicamentData = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRequestSent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "VERIFIQUE SU PEDIDO\r\n\r\nSI ES CORRECTO, DARLE CLIC EN ENVIAR";
            // 
            // lblMedicamentData
            // 
            this.lblMedicamentData.AutoSize = true;
            this.lblMedicamentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamentData.Location = new System.Drawing.Point(70, 141);
            this.lblMedicamentData.Name = "lblMedicamentData";
            this.lblMedicamentData.Size = new System.Drawing.Size(0, 17);
            this.lblMedicamentData.TabIndex = 1;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(70, 202);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(0, 17);
            this.lblAdress.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(67, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(335, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 65);
            this.button2.TabIndex = 4;
            this.button2.Text = "ENVIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRequestSent
            // 
            this.lblRequestSent.AutoSize = true;
            this.lblRequestSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestSent.ForeColor = System.Drawing.Color.Blue;
            this.lblRequestSent.Location = new System.Drawing.Point(225, 350);
            this.lblRequestSent.Name = "lblRequestSent";
            this.lblRequestSent.Size = new System.Drawing.Size(0, 24);
            this.lblRequestSent.TabIndex = 5;
            this.lblRequestSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Confirm_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(589, 391);
            this.Controls.Add(this.lblRequestSent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblMedicamentData);
            this.Controls.Add(this.label1);
            this.Name = "Confirm_Form";
            this.Text = "confirmacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedicamentData;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblRequestSent;
    }
}