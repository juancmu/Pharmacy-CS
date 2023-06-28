using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act2Pharmacy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

 

        private void btnConfirm_Click(object sender, EventArgs e)
        {
             Console.WriteLine("HELLO");
            MessageValidation messageValidation = new MessageValidation();
            messageValidation.ShowDialog();

            Confirm_Form confirm_Form = new Confirm_Form();
            confirm_Form.ShowDialog();

        }

        private void btnErase_Click(object sender, EventArgs e)
        {

            this.txtNameMedicament.Text = "";
            this.cmbBoxNameMedicament.Text = "";
            this.txtQtyMedicament.Text = "";
            this.rBtnCofarma.Checked = false;
            this.rBtnEmpsephar.Checked = false;
            this.rBtnCemefar.Checked = false;
            this.chkBoxSecondVendor.Checked = false;
            this.chkBoxMainVendor.Checked = false;
            this.error1.Text = "";
            this.error2.Text = "";
            this.error3.Text = "";
            this.error4.Text = "";
            this.error5.Text = "";



        }


    }
}
