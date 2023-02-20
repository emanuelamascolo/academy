using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Immobile
    {
        //{codice, tipologia, prezzo, città, superficie}
        public int Codice { get; set; }
        public string Tipologia { get; set; }
        public float Prezzo { get; set; }   
        public string Citta { get; set; }
        public int Superficie { get; set; }

        public Immobile(int codice, string tipologia, float prezzo, string citta, int superficie)
        {
            Codice = codice;
            Tipologia = tipologia.ToLower();
            Prezzo = prezzo;
            Citta = citta.ToLower();
            Superficie = superficie;
        }

        public void StampaDati()
        {
            Console.WriteLine($"CODICE: {Codice}, PREZZO: {Prezzo}, SUPERFICIE: {Superficie} mq, ZONA: {Citta}");
        }
    }
}
