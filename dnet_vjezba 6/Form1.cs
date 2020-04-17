using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnet_vjezba_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Valuta> sveValute = new List<Valuta>();
        Valuta v;

        private void button1_Click(object sender, EventArgs e)
        {
            v = new Valuta();
            v.Naziv = textBox1.Text;
            v.Tecaj = Convert.ToDouble(textBox2.Text);
            sveValute.Add(v);
            sveValute.Sort();
            prikaziListuValuta();
        
        }


        private void button2_Click(object sender, EventArgs e)
        {
                MessageBox.Show(v.Ispis());
        }

        void prikaziListuValuta() 
        {
            string sve = "Lista valuta:\n";
            foreach (Valuta v in sveValute)
            {
                sve += v.Naziv.ToUpper() + " " + v.Tecaj + "\n"; 
            }
            MessageBox.Show(sve);
        }
    }
}
