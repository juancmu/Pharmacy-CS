﻿namespace Act2Pharmacy
{
    partial class MessageValidation
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblErrorMesasage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(154, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Corregir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblErrorMesasage
            // 
            this.lblErrorMesasage.AutoSize = true;
            this.lblErrorMesasage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMesasage.Location = new System.Drawing.Point(94, 37);
            this.lblErrorMesasage.Name = "lblErrorMesasage";
            this.lblErrorMesasage.Size = new System.Drawing.Size(0, 25);
            this.lblErrorMesasage.TabIndex = 1;
            // 
            // MessageValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(530, 270);
            this.Controls.Add(this.lblErrorMesasage);
            this.Controls.Add(this.button1);
            this.Name = "MessageValidation";
            this.Text = "Hay Inconsistencias en su pedido, revisar:";
            this.Load += new System.EventHandler(this.messageValidation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblErrorMesasage;
    }
}