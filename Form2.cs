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
    public partial class Confirm_Form : Form
    {
        public Confirm_Form(string nameMedicament, string typeMedicament, int qtyMedicament, string typeVendor, bool mainVendor, bool secondVendor)
        {
            InitializeComponent();

            string adressMessage = "Para la Farmacia Situada en ";

            this.Text = "PEDIDO REALIZADO AL DISTRIBUIDOR " + typeVendor;
            this.lblMedicamentData.Text = qtyMedicament + " Unidades del " + typeMedicament + " " + nameMedicament;
         

            if (mainVendor)
            {

                adressMessage = adressMessage + "Calle de la Rosa No. 28";
            }
            if (mainVendor && secondVendor)
            {

                adressMessage = adressMessage + "\r\n y para la farmacia situada en ";
            }
          
            if (secondVendor)
            {


                adressMessage = adressMessage + "Calle Alcazabilla No. 3";
                  
            }


            this.lblAdress.Text = adressMessage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PEDIDO ENVIADO");
            this.lblRequestSent.Text = "PEDIDO ENVIADO";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
