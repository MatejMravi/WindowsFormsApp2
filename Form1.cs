using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //----------------------------------------
        // Vypisuje tlacitka na displej
        //----------------------------------------
        private void bt_tlacitko_zero_Click(object sender, EventArgs e)
        {
            Button lbtMojeTlacitko;

            lbtMojeTlacitko = (Button)sender;

            // test zda tam není samotná nula
            if (txtdisplay.Text == "0") txtdisplay.Text = "";
            // Vypsat cislo na display
            txtdisplay.Text = txtdisplay.Text + lbtMojeTlacitko.Text;
        }
        //---------------------------------------------
        //Vycisti kalkulacku
        //---------------------------------------------
        private void bt_smazat_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
        }
    }
}
