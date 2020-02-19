using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nazwisko_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = textBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;
            int wiek = int.Parse(textBoxWiek.Text);

            if (wiek >= 67)
                labelWynik.Text = "jesteś emerytem";
            else
                labelWynik.Text = $"do emerytury zostało ci {67 - wiek} lat";
        }
    }
}
