using System.Security.Cryptography;

namespace obiektowe
{
    class motocyl{
         private string pojemnosc;

        public string poj {
            get { return pojemnosc; }
            set { pojemnosc = value; } 
        
        }




    }



    class samochod
    {
       private string marka, model;
        int rok;

        void wyswietl()
        {

            Console.WriteLine("Marka: " + marka + " Model: " + model + " Rok produkcji: " + rok);
        
        } 

        samochod(string marka = "0000", string model = "0000", int data = 22)
        {
            this.marka = marka;
            this.model = model;
            rok = data;
        }

        samochod()
        {
            marka = "brak";
            model = "brak";
            rok = 0;
        }



        static void Main(string[] args)
        {
            samochod s1 = new samochod("Fiat","125p", 1973);
            samochod s2 = new samochod();
            samochod s3 = new samochod("VW");

            motocyl m1 = new motocyl();

            m1.poj = "2222";


            Console.Write( m1.poj);


            s1.model = "Renault";
            s1.wyswietl();


            s2.wyswietl();
            s3.wyswietl();
           


           
        }
    }


}