using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodEZ_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ricerca(object sender, EventArgs e)
        {
            textBox2.Clear();
            string Asin = ClasseAPI.ReqAsin(textBox1.Text);

            if(Asin=="Prodotto non trovato")
            {
                MessageBox.Show(Asin);
                return;
            }
            textBox2.Text = ClasseAPI.ReqLink(Asin);
        }
    }
}
