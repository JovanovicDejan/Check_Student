using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create instance of class
            clsStudent Student = new clsStudent(Convert.ToInt32(txtIndeks.Text));

            //Take user input
            string Ime = txtIme.Text;
            string Prezime = txtPrezime.Text;

            //Converting string to numbers
            int UpisanaGodina = Convert.ToInt32(txtGodinaUpisa.Text);
            int GodinaRodjenja = Convert.ToInt32(txtGodinaRodjenja.Text);

            //Give value to attributes from class Student
            Student.Ime = Ime;
            Student.Prezime = Prezime;
            Student.upisanaGodina = UpisanaGodina;
            Student.godinaRodjenja = GodinaRodjenja;

            Student.Save();

            MessageBox.Show("Podaci su uspesno sacuvani");

        }
    }
}
