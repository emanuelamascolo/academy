using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        /*
         agenzia: immobili {codice, tipologia, prezzo, città, superficie} 
                  mostraimmobile(string ordinatiPer(prezzo, città o superficie)) -> stampa
                aggiungi immobile(codice, tipologia, prezzo, città, superficie) -> add lista
                //codice univoco!!
                rimuove immobile() -> 
                getImmobilePiuGrande()/Caro()
                get valore totale immobili()

         */
        static void Main(string[] args)
        {
            string ricercaPer, tipologia, citta;
            int codice, superficie;
            float prezzo;

            var i1 = new Immobile(12, "appartamento", 50000, "scalea", 30);
            var i2 = new Immobile(1, "appartamento", 500000, "napoli", 80);
            var i3 = new Immobile(2, "villa", 850000, "ischia", 100);
            List<Immobile> listaI = new List<Immobile>() { i1, i2, i3 }; 

            var agenzia = new Agenzia("cerco casa");

            Console.WriteLine("in quale ordine mostro gli immobili? [prezzo, città o superficie]");
            ricercaPer = Console.ReadLine();
            agenzia.MostraImmobile(ricercaPer);

            Console.WriteLine("aggiunta immobili in corso...");
            agenzia.Immobili = listaI;      //adesso agenzia contiene 12,1,2

            //mostra
            Console.WriteLine("in quale ordine mostro gli immobili? [prezzo, città o superficie]");
            ricercaPer = Console.ReadLine();
            agenzia.MostraImmobile(ricercaPer);

            //aggiungi
            Console.WriteLine("inserire codice: ");
            codice = int.Parse(Console.ReadLine());
            Console.WriteLine("inserire tipologia: ");
            tipologia = Console.ReadLine();
            Console.WriteLine("inserire prezzo: ");
            prezzo = float.Parse(Console.ReadLine());
            Console.WriteLine("inserire citta: ");
            citta = Console.ReadLine();
            Console.WriteLine("inserire superficie: ");
            superficie = int.Parse(Console.ReadLine());

            agenzia.AddImmobile(codice, tipologia, prezzo, citta, superficie);

            Console.WriteLine("inserire codice: ");
            codice = int.Parse(Console.ReadLine());
            Console.WriteLine("inserire tipologia: ");
            tipologia = Console.ReadLine();
            Console.WriteLine("inserire prezzo: ");
            prezzo = float.Parse(Console.ReadLine());
            Console.WriteLine("inserire citta: ");
            citta = Console.ReadLine();
            Console.WriteLine("inserire superficie: ");
            superficie = int.Parse(Console.ReadLine());

            agenzia.AddImmobile(codice, tipologia, prezzo, citta, superficie);

            //mostra
            Console.WriteLine("in quale ordine mostro gli immobili? [prezzo, città o superficie]");
            ricercaPer = Console.ReadLine();
            agenzia.MostraImmobile(ricercaPer);

            //rimuovi
            Console.WriteLine("inserire codice dell'immobile da eliminare: ");
            codice = int.Parse(Console.ReadLine());
            agenzia.RemoveImmobile(codice);


            //mostra
            Console.WriteLine("in quale ordine mostro gli immobili? [prezzo, città o superficie]");
            ricercaPer = Console.ReadLine();
            agenzia.MostraImmobile(ricercaPer);

            Console.WriteLine("immobile con superficie più grande: ");
            agenzia.GetImmobilePiuGrande();

            Console.WriteLine("immobile più caro: ");
            agenzia.GetImmobilePiuCaro();

            agenzia.GetValoreTotaleImmobili();

            Console.ReadLine();







        }
    }
}
