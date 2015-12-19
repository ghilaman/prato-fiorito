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
        static int[,] campo = new int[righe, colonne];
         
        static void Main(string[] args)
        {
            


        }

        static int [,] preparazioneCampo()
        {
            Random mine = new Random();
            
            for (int i = 0; i < 9; i++)
            {
                int rigamina;
                int colonnamina;
                do
                {
                    rigamina = mine.Next(1, 9);
                    colonnamina = mine.Next(1, 9);
                } while (campo[rigamina,colonnamina] == 1);
                campo[rigamina, colonnamina] = 1;   
            }
            return campo;
        }
        
        
    
    }
}
