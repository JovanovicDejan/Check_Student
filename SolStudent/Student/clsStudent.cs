using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class clsStudent
    {
        // Creating private attributes
        private int p_brojIndeksa;
        private int p_upisanaGodina;
        private int p_godinaRodjenja;

        //Create public attributes
        public string Ime;
        public string Prezime;

        //Create public methods so we can access private attributes
        public clsStudent(int BrojIndeksa)
        {
            this.BrojIndeksa = BrojIndeksa;
        }

        //Constructor with three parameters
        public clsStudent(int BrojIndeksa, string Ime, string Prezime)
        {
            this.BrojIndeksa = BrojIndeksa;
            this.Ime = Ime;
            this.Prezime = Prezime;
        }

        public int BrojIndeksa
        {
            get { return p_brojIndeksa; }
            set 
            { 
                //Create if statement for checking user input
                if(value < 1 || value > 999)
                {
                    //Create exception and breake the application
                    throw new Exception("Broj indeksa mora biti u opsegu od 1 do 999");
                }
                //Give value to private attribut if everything work's fine
                p_brojIndeksa = value; 
            }
        }
        public int upisanaGodina
        {
            get { return p_upisanaGodina; }
            set
            {
                if(value < 1 || value > 5)
                {
                    throw new Exception("Godina studija mora biti u opsegu od 1 do 6");
                }
                p_upisanaGodina = value;
            }
        }
        public int godinaRodjenja
        {
            get { return p_godinaRodjenja; }
            set
            {
                if((DateTime.Now.Year - value) < 18)
                {
                    throw new Exception("Student mora imati najmanje 18 godina");
                }
                p_godinaRodjenja = value;
            }
        }

        //Create constructor

        //Constructor with one parameter
        public void Save()
        {
            try
            {
                //Save data to file named brojIndeksa that user type using StreamWriter
                StreamWriter sw = new StreamWriter("C:\\Students\\" + this.p_brojIndeksa.ToString() + ".txt");
                sw.WriteLine("Ime: " + this.Ime);
                sw.WriteLine("Prezime: " + this.Prezime);
                sw.WriteLine("Broj indeksa: " + this.p_brojIndeksa);
                sw.WriteLine("Upisana godina: " + this.p_upisanaGodina);
                sw.WriteLine("Godina rodjenja: " + this.p_godinaRodjenja);
                sw.Flush();
                sw.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        ~clsStudent()
        {
            System.Diagnostics.Trace.WriteLine("Klasa dealocirana");
        }
    }
}
