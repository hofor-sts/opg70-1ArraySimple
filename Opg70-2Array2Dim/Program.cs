using System;

namespace Opg70_2Array2Dim
{
    class Program
    {
        static void Main()
        {
            string[,] navne = new string[4,2];
            navne[0, 0] = "1";
            navne[1, 0] = "2";
            navne[2, 0] = "3";
            navne[3, 0] = "4";
            navne[0, 1] = "navn1";
            navne[1, 1] = "navn2";
            navne[2, 1] = "navn3";
            navne[3, 1] = "navn4";
            Console.WriteLine(FindNavn(navne, "1"));

            static string FindNavn(string[,] ar, string id)
            {
                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    if (ar[i, 0] == id)
                        return ar[i, 1];
                }
                return "?";
            }

        }
    }
}
