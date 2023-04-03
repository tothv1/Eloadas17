using Osztaly_Konyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Konyv osztály
            //isbnSzam
            //Szerző(k)
            //Mű címe
            //kiadási éve
            //nyelv
            //enciklopédia vagy nem? bool
            //ebook i/n - char
            //0-8365-6668-8
            KonyvesPolc konyvesPolc = new KonyvesPolc();
            try
            {
                Konyv konyv1 = new Konyv("0836566688", "Valaki", "A asdadssad", 2022, "Magyar", true, 'i');
                Konyv konyv2 = new Konyv("0544051904", "Valak22i", "A asdadss3232ad", 2012, "Magyar", true, 'n');

                konyvesPolc.addKonyv(konyv1);
                konyvesPolc.addKonyv(konyv2);
            }
            catch (ISBN_NumberLengthException e)
            {
                Console.WriteLine(e.Message);
            } catch (ISBN_NumberFormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(konyvesPolc.KonyvekSzama);
            Console.WriteLine(konyvesPolc.getKonyvekSzama());
            
            
            


            /*bool helyes = false;
            do
            {
                
                Console.Write("Add meg az ISBN számot: ");
                try
                {
                    string bekert = Console.ReadLine();
                    string nums="";
                    foreach (var item in bekert.Split('-'))
                    {
                        nums+= item;
                    }
                    k.IsbnSzam = nums;
                    Console.WriteLine("A megadott ISBN kód helyes! A program kilép...");
                    helyes = true;
                }
                catch (ISBN_NumberLengthException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ISBN_NumberFormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!helyes);*/

            

            Console.ReadKey();
        }
    }
}
