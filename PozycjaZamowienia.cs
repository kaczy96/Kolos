using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos
{
    class PozycjaZamowienia
    {
        public string nazwaTowaru { get; set; }
        public float cenaJednostkowa { get; set; }
        public float stawkaVAT = 0.22f;
        public float ilosc { get; set; }

        public double obliczBrutto()
        {
            double cenaBrutto = cenaJednostkowa * ilosc;
            return cenaBrutto;
        }

        public double obliczNetto()
        {
            double cenaNetto = cenaJednostkowa * ilosc - ((cenaJednostkowa * ilosc) * stawkaVAT);
            return cenaNetto;
        }
    }
}
