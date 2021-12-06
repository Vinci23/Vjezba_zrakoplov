using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_i_objekti
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov();

            x380.setNaziv("Airbus");
            x380.setSnagaMotora(2000);
            x380.setDosegLeta(6000);

            Console.WriteLine("Naziv: "+x380.getNaziv());
            Console.WriteLine("Doseg leta: "+x380.getDosegLeta()+ "kW");
            Console.WriteLine("Snaga motora: "+x380.getSnagaMotora() + "km");
            Console.WriteLine("     ");

            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher",850,75 );
            Console.WriteLine(C162.ToString());

            Console.WriteLine("    ");

            Zrakoplov PC_21 = new Zrakoplov("Pilatus", 1333, 1200);
            Console.WriteLine(PC_21.ToString());

            Console.ReadKey();
        }
    }
    class Zrakoplov
    {
        String Naziv;
        double snagaMotora;
        int dosegLeta;

        public override string ToString()
        {
            string ispis = ("Naziv: " + this.getNaziv() + "\n" +
             "Snaga motora=> " + this.getSnagaMotora() +"kW"+"\n" +
             "Doseg leta=> " + this.getDosegLeta()+"km");
            return ispis;
        }

        public Zrakoplov()
        {

        }

        public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
        {
            this.Naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dosegLeta = dosegLeta;
        }

        public void setNaziv(String Naziv)
        {
            this.Naziv = Naziv;
        }

        public void setSnagaMotora(double snagaMotora)
        {
            this.snagaMotora = snagaMotora;
        }

        public void setDosegLeta(int dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }

        ///////////////////////////////////
        
        public String getNaziv()
        {
            return this.Naziv;
        }

        public double getSnagaMotora()
        {
            return this.snagaMotora;
        }
            
        public int getDosegLeta()
        {
            return this.dosegLeta;
        }

    }
}
