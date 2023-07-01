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
    public partial class MessageValidation : Form
    {
        public MessageValidation(bool e1, bool e2, bool e31, bool e32, bool e4, bool e5)
        {
            InitializeComponent();

            String[] messError = new String[6];

            messError[0] = e1 ? "El nombre del medicamento esta vacio" : "";
            messError[1] = e2 ? "No ha seleccionado tipo de medicamento" : "";
            messError[2] = e31 ? "No ha ingresado la cantidad de medicamento" : "";
            messError[3] = e32 ? "La cantidad ingresada no puede ser cero" : "";
            messError[4] = e4 ? "No ha Seleccionado el distribuidor" : "";
            messError[5] = e5 ? "Debe seleccionar al menos una sucursal" : "";

            String messTotal = "";

            for (int i = 0; i < 6; i++)  {

                if (messError[i] != "")
                {
                    messTotal += messError[i] + "\r\n";
                }

            }            

           

             
                this.lblErrorMesasage.Text = messTotal;

            

        }
            private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void messageValidation_Load(object sender, EventArgs e)
        {

        }
    }
}
