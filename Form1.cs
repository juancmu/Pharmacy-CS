using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Act2Pharmacy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string nameMedicament, typeMedicament, typeVendor;
        int qtyMedicament;
        public bool error1Check, error2Check, error3Check1, error3Check2, error4Check, error5Check = false;
        private void btnConfirm_Click(object sender, EventArgs e)
        {

           
            /// 
            if (this.txtNameMedicament.Text == "")
            {
                error1Check = true;
                this.error1.Text = "Ingrese el nombre del \r\nmedicamento";
            } else {
                error1Check = false;
                nameMedicament = this.txtNameMedicament.Text;

            }
            ///
            if (this.cmbBoxTypeMedicament.Text == "")
            {
                error2Check = true;
                this.error2.Text = "Seleccione el tipo de medicamento";
            }
            else
            {
                error2Check = false;
                typeMedicament = this.cmbBoxTypeMedicament.Text;
            }
            ///
            if (this.txtQtyMedicament.Text == "")
            {
                error3Check1 = true;
                this.error3.Text = "Ingrese la cantidad";
            } else {
                error3Check1 = false;
                qtyMedicament = int.Parse(this.txtQtyMedicament.Text);
                if (qtyMedicament == 0) {
                    error3Check2 = true;
                    this.error3.Text = "La cantidad de medicamento no puede ser cero";
                } else { error3Check2 = false; }

            }

            ///
            
            bool cofarma = this.rBtnCofarma.Checked;
            bool empsephar = this.rBtnEmpsephar.Checked;
            bool cemefar = this.rBtnCemefar.Checked;


            if (cofarma)
            {
                error4Check = false;
                typeVendor = "COFARMA";

            } else if (empsephar) {
                error4Check = false;
                typeVendor = "EMSEPHAR";
            } else if (cemefar) {
                error4Check = false;
                typeVendor = "CEMEFAR";
            } else
            {
                error4Check = true;
                this.error4.Text = "Favor seleccionar \r\n el Distribuidor";
            }

            ///

            bool mainVendor = this.chkBoxMainVendor.Checked;
            bool secondVendor = this.chkBoxSecondVendor.Checked;

            if (mainVendor || secondVendor) {
                error5Check = false;

            } else
            {
                error5Check = true;
                this.error5.Text = "Debe seleccionar al menos\r\nuna sucursal";
            }

            /// actions

            if (error1Check || error2Check || error3Check1 || error3Check2 || error4Check || error5Check)
            {


                MessageValidation messageValidation = new MessageValidation(error1Check , error2Check , error3Check1 , error3Check2 , error4Check , error5Check);
                messageValidation.ShowDialog();

                Console.WriteLine(error1Check);

            } else
            {
                Confirm_Form confirm_Form = new Confirm_Form(nameMedicament, typeMedicament, qtyMedicament, typeVendor, mainVendor, secondVendor);
                confirm_Form.ShowDialog();

            }
            ///            Confirm_Form confirm_Form = new Confirm_Form();
            ///        confirm_Form.ShowDialog();

        }

        private void btnErase_Click(object sender, EventArgs e)
        {

            this.txtNameMedicament.Text = "";
            this.cmbBoxTypeMedicament.SelectedIndex = -1;
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

       

        private void txtQtyMedicament_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyinteger(sender, e);
        }

        private void txtNameMedicament_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyCharacters(sender, e);
        }




        /// validate characters function
        
        public void onlyCharacters(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
            {

                this.error1.Text = "Favor ingresar solo letras";
                e.Handled = true;
                return;
            }
            else
            {
                this.error1.Text = "";


            }


        }

        /// validate characters function

        public void onlyinteger(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {

                this.error3.Text = "Favor ingresar solo Numeros";
                e.Handled = true;
                return;
            }
            else
            {
                this.error3.Text = "";


            }


        }

        private void txtNameMedicament_Leave(object sender, EventArgs e)
        {
            this.error1.Text = "";
        }

        private void cmbBoxTypeMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.error2.Text = "";
        }

        private void rBtnCemefar_Enter(object sender, EventArgs e)
        {
            this.error4.Text = "";
        }

        private void rBtnEmpsephar_Enter(object sender, EventArgs e)
        {
            this.error4.Text = "";
        }

        private void rBtnCofarma_Enter(object sender, EventArgs e)
        {
            this.error4.Text = "";
        }

        private void chkBoxSecondVendor_Enter(object sender, EventArgs e)
        {
            this.error5.Text = "";
        }

        private void chkBoxMainVendor_Enter(object sender, EventArgs e)
        {
            this.error5.Text = "";
        }
    }
}
