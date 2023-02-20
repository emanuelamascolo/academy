using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Agenzia
    {
        public string Nome { get; set; }
        public List<Immobile> Immobili { get; set; }

        public Agenzia(string nome)
        {
            Nome = nome;
            Immobili = new List<Immobile>();
        }

        public void MostraImmobile(string OrdinatiPer)
        {
            if(Immobili.Count == 0)
            {
                Console.WriteLine("nessun immobile presente!");
            }

            //prezzo, città o superficie
            var iOrdinati = Immobili.OrderBy(f => f.Codice);

            switch (OrdinatiPer)
            {
                case "prezzo":
                    iOrdinati = Immobili.OrderBy(f => f.Prezzo);
                    break;
                case "citta":
                    iOrdinati = Immobili.OrderBy(f => f.Citta);
                    break;
                case "superficie":
                    iOrdinati = Immobili.OrderBy(f => f.Superficie);
                    break;
                default:
                    Console.WriteLine("valore non valido! stampa in ordine di codice..");
                    break;
            }

            foreach(var elem in iOrdinati)
            {
                elem.StampaDati();
            }

            
        }

        //aggiungi immobile(codice, tipologia, prezzo, città, superficie) -> add lista
        public void AddImmobile(int codice, string tipologia, float prezzo, string citta, int superficie)
        {
            if (Immobili.Any((i) =>  i.Codice == codice))   //true
            {
                Console.WriteLine("codice già esistente!");
            }
            else
            {
                var i = new Immobile(codice, tipologia, prezzo, citta, superficie);
                Immobili.Add(i);
            }
        }

        public void RemoveImmobile(int codice)
        {
            Immobile trovato = Immobili.Find((f) => { return f.Codice == codice; });
            if (trovato != null)
            {
                //remove
               Immobili.Remove(trovato);
            }
            else
            {
                Console.WriteLine("immobile non trovato!");
            }
        }



        public void GetImmobilePiuGrande()
        {
            var i = Immobili.OrderByDescending(f => f.Superficie);
            i.First().StampaDati();

        }

        public void GetImmobilePiuCaro()
        {
            var i = Immobili.OrderByDescending(f => f.Prezzo);
            i.First().StampaDati();
        }

        public void GetValoreTotaleImmobili()
        {
            //float somma = 0;
            //foreach(var i in Immobili)
            //{
            //    somma += i.Prezzo;
            //}
            //Console.WriteLine("il valore di tutti gli immobili è: " + somma);
            
            Immobili.Sum(f => f.Prezzo);
            Console.WriteLine("il valore di tutti gli immobili è: " + Immobili.Sum(f => f.Prezzo));
        }


    }
}
