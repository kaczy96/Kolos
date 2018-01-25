using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos
{
    class Platnosc
    {
        void zaplacPrzelewem()
        {
            Console.WriteLine("Dane do przelewu");
            Przelew przelew = new Przelew();
            Console.WriteLine("Nr konta: {0}", przelew.kontoBankowe);
            Console.WriteLine("Tytuł przelewu: {0}", przelew.tytulPrzelewu);
        }

        void wezKredyt()
        {
            Kredyt kredyt = new Kredyt();
            Console.WriteLine("Nazwa banku: {0}", kredyt.bank);
            Console.WriteLine("Liczba rat: {0}", kredyt.liczbaRat);
            Console.WriteLine("Oprocentowanie roczne: {0}",kredyt.oprocentowanieRoczne);
        }

        void gotowka()
        {
            Console.WriteLine("Zaplacono gotówką");
        }
    }
}
