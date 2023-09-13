using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso_pre_rientro
{
    public struct Campi
       {
           public string comune;
           public string provincia;
           public string regione;
           public string nome;
           public int anno;
           public string data;
           public float identificatore;
           public string longitudine;
           public string latitudine;
       }

   internal class Program
   {

       public static string nfile = @"Zappa.csv";
       static void Main(string[] args)
       {
           Funzioni f = new Funzioni();
           string path = @"Zappa.csv";
           string sep = ";";
           int l = 124;
           int scelta = 0;
           int recordLenght = 124;
           do
           {
               Console.Clear();
               Console.WriteLine("Menù");
               Console.WriteLine("1 - Aggiunta campo");
               Console.WriteLine("2 - Conta campi ");
               Console.WriteLine("3 - Lunghezza massima record");
               Console.WriteLine("4 - Spazi univoci record");
               Console.WriteLine("5 - Aggiunta in coda");
               Console.WriteLine("6 - Visualizza");
               Console.WriteLine("7 - Ricerca");
               Console.WriteLine("8 - Modifica");
               Console.WriteLine("9 - Cancellazione logica");
               Console.WriteLine("Inserisci la scelta");
               scelta = int.Parse(Console.ReadLine());
               switch (scelta)
               {
                   case 1:
                       string nomefile = @"Zappa.csv";
                       f.Aggiuntacampo(nomefile);
                       Console.ReadLine();
                       Console.WriteLine("E' stato aggiunto il campo");
                       break;
                   case 2:

                       int contacampi = f.Contacampi();
                       Console.WriteLine("Il numero dei campi è: " + contacampi);
                       break;
                   case 3:
                       int lung = f.Lunghmax();
                       Console.WriteLine("La lunghezza massima è: " + lung);
                       break;
                   case 4:
                       f.Spazi();
                       Console.WriteLine("Ogni record ha la stessa dimensione");
                       break;
                   case 5:
                       Console.WriteLine("Inserisci campo 1");
                       string c1 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 2");
                       string c2 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 3");
                       string c3 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 4");
                       string c4 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 5");
                       string c5 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 6");
                       string c6 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 7");
                       string c7 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 8");
                       string c8 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 9");
                       string c9 = Console.ReadLine();

                        f.c = f.sp(c1, c2, c3, c4, c5, c6, c7, c8, c9);
                       f.AggProd(f.Record(f.c, recordLenght), path);
                       Console.WriteLine("I campi sono stati aggiunti al file");
                       break;
                   case 6:
                       Console.WriteLine("Visualizza");
                       break;
                   case 7:
                       Console.WriteLine("Inserisci un elemento da ricercare");
                       string cerca = Console.ReadLine();
                       int riga = f.Ricerca(cerca, path);
                        if(riga == -1)
                        {
                            Console.WriteLine("Elemento non presente");
                        }
                        else
                        {
                            Console.WriteLine("Elemento presente alla riga " + riga);
                        }
                       break;
                   case 8:
                       Console.WriteLine("Inserisci campo per la modifica");
                       string mod = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 1 da modificare");
                       string ca1 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 2 da modificare");
                       string ca2 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 3 da modificare");
                       string ca3 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 4 da modificare");
                       string ca4 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 5 da modificare");
                       string ca5 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 6 da modificare");
                       string ca6 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 7 da modificare");
                       string ca7 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 8 da modificare");
                       string ca8 = Console.ReadLine();
                       Console.WriteLine("Inserisci campo 9 da modificare");
                       string ca9 = Console.ReadLine();
                       f.Modifica(mod, ca1, ca2, ca3, ca4, ca5, ca6, ca7, ca8, ca9, path, sep, l);
                       break;
                   case 9:
                       int ncampi = f.Contacampi();
                       Console.WriteLine("Inserisci l'elemento da cancellare");
                       string cancellato = Console.ReadLine();
                       f.CancellazioneLogica(cancellato);
                        Console.WriteLine("Cancellazione logica eseguita");
                       break;
               }

               Console.ReadLine();
           } while (scelta != 0);

       }


      
       
}
}
