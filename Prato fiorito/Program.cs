using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prato_fiorito
{
    class Program
    {
        static int contatore;
        static int n_mine = 9;
        static int colonne = 9;
        static int righe = 9;
        static int colonnautente;
        static int rigautente;
        static int[,] campo = new int[righe, colonne];
        static string[,] campoutente= new string [righe, colonne];

        static void Main(string[] args)
        {
            campo = preparazioneCampo();
            completamentoVisioneCampoUtente();
            
            while (contatore < (colonne*righe)-n_mine)
            {
                richiesta();
                controllo();
            }
            
        }

        static int[,] preparazioneCampo()
        {
            Random mine = new Random();

            for (int i = 0; i < righe; i++)
            {
                int rigamina;
                int colonnamina;
                do
                {
                    rigamina = mine.Next(1, righe);
                    colonnamina = mine.Next(1, colonne);
                } while (campo[rigamina, colonnamina] == 1);
                campo[rigamina, colonnamina] = 1;
            }
            return campo;
        }
        static void richiesta()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            bool verifica;
            do
            {
                Console.WriteLine("dammi la riga");
                verifica = Int32.TryParse(Console.ReadLine(), out rigautente);
                if (!verifica || rigautente < 0 || rigautente > 8)
                {
                    Console.WriteLine("inserire un valore corretto");
                }

            } while (!verifica || rigautente > 8|| rigautente<0);

            bool verifica2;
            do
            {
                Console.WriteLine("dammi la colonna");
                verifica2 = Int32.TryParse(Console.ReadLine(), out colonnautente);
                if (!verifica2 || colonnautente < 0 || colonnautente > 8)
                {
                    Console.WriteLine("inserire un valore corretto");
                }

            } while (!verifica2 || colonnautente > 8 || colonnautente < 0);
        }
        static void controllo()
        {

            if (campo[rigautente, colonnautente] == 1)
            {
                campoutente[rigautente, colonnautente] = "X";
                Console.WriteLine("HAI PRESO UNA BOMBA, HAI PERSO!");
                visioneCampoUtente();
                System.Environment.Exit(contatore);
            }
            else
                if ((campoutente[rigautente, colonnautente] == "L"))
                {
                    Console.WriteLine("numeri già inseriti");
                }
                else 
                    if (campo[rigautente, colonnautente] == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("non hai preso una bomba");
                        campoutente[rigautente, colonnautente] = "L";
                        visioneCampoUtente();
                        contatore++;
                    }
        }  
        static void Comunicazione()
        {
            

        }
        static void completamentoVisioneCampoUtente()
        {

            for (int r = 0; r < 9; r++)
            {
                Console.WriteLine("");
                for (int c = 0; c < 9; c++)
                {
                    campoutente[r, c] = "O";
                    Console.Write(campoutente[r, c]);
                }
            } 
        }
        static void visioneCampoUtente()
        {
            for (int r = 0; r < 9; r++)
            {
                Console.WriteLine("");
                for (int c = 0; c < 9; c++)
                    Console.Write(campoutente[r, c]);
            }
        }
     
    }
   



}

