using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waz
{

    public enum Kierunek
    {
        Gora,
        Dol,
        Prawo,
        Lewo
    };
    class Ustawienia
    {
        public static int Szerokosc { get; set; }
        public static int Wysokosc { get; set; }
        public static int Predkosc { get; set; }
        public static int Wynik { get; set; }
        public static int DodanePkt { get; set; }
        public static bool KoniecGry { get; set; }
        public static Kierunek kierunek { get; set; }
        
        public Ustawienia()
        {
            Szerokosc = 20;
            Wysokosc = 20;
            Predkosc = 20;
            Wynik = 0;
            DodanePkt = 1;
            KoniecGry = false;
            kierunek = Kierunek.Prawo; 
        }

}
}
