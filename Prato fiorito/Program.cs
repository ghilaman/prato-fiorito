using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prato_fiorito
{
    class Program
    {
        static int n_mine = 9;
        static int colonne = 9;
        static int righe = 9;
        static int colonnautente;
        static int rigautente;
        static int[,] campo = new int[righe, colonne];

        static void Main(string[] args)
        {
            campo = preparazioneCampo();
            richiesta();
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
            bool verifica;
            do
            {
                Console.WriteLine("dammi la riga");
                verifica = Int32.TryParse(Console.ReadLine(), out rigautente);
                if (!verifica || rigautente < 1 || rigautente > 9)
                {
                    Console.WriteLine("inserire un valore corretto");
                }

            } while (!verifica || rigautente > 9|| rigautente<1);

            bool verifica2;
            do
            {
                Console.WriteLine("dammi la colonna");
                verifica2 = Int32.TryParse(Console.ReadLine(), out rigautente);
                if (!verifica2 || rigautente < 1 || rigautente > 9)
                {
                    Console.WriteLine("inserire un valore corretto");
                }
                    
            } while (!verifica2 || colonnautente > 9|| colonnautente<1);

        }
    }




}

