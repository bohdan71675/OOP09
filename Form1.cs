using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stroj stroj = new Stroj("567AbC", DateTime.Parse("1/01/2022"));
        private void button1_Click(object sender, EventArgs e)
        {
            stroj.ProvedServis();
            MessageBox.Show(stroj.ToString());
        }
        Automat automat = new Automat("567AbC", DateTime.Parse("1/01/2022"), false);
        private void button2_Click(object sender, EventArgs e)
        {
            automat.ProvedServis();
            automat.Preprogramuj();
            MessageBox.Show(automat.ToString());
        }
    }
}
