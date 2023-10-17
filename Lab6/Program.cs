using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankClient clientOne = new BankClient("Jani", "1234", "Budapest");
            //Console.WriteLine(clientOne.GetAllClientData());
            //BankClient clientTwo = new BankClient("Kati", "1234", "Debrecen");
            #region 1. feladat
            /*
            Book firstBook = new Book("J.R.R. Tolkien", "The Hobbit - or There and Back Again", 1937, 312);
            Console.WriteLine(firstBook.AllData());
            */
            #endregion
            #region 3. feladat
            /*
            Runner runner1 = new Runner("Jani", 1, 2);
            Runner runner2 = new Runner("Kati", 2, 1);
            while (runner1.GetDistance() != 20 || runner2.GetDistance() != 20)
            {
                Console.Clear();
                runner1.RefreshDistance(1);
                runner1.Show();
                runner2.RefreshDistance(1);
                runner2.Show();
                System.Threading.Thread.Sleep(1000);
            }
            */
            #endregion
            #region 4. feladat
            /*
            Caesar text1 = new Caesar(5);
            string code = text1.Encode("alma almaalma alma");
            Console.WriteLine(code);
            Console.WriteLine(text1.Decode(code));
            */
            #endregion

            Console.ReadLine();
        }
    }
}
