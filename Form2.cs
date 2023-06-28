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
        public Confirm_Form()
        {
            InitializeComponent();
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
