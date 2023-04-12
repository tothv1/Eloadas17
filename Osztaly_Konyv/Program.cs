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


            //Konyv osztályba + leltári szám pontosan 11 karakter
            //minden mezőt ellenörző adatbevitelel elkésziteni
            //Szerző minimum 6 karakter
            //Mű cime minimum 1 karakter
            //Kiadás éve -10000 -- 2023 akt évig
            //nyelv nem lehet üres
            //enci - true/false
            //eBook i/n
            //Minden hibát saját exceptionnal megoldani!!!!
            //Konyvespolc osztályban Szótárat létrehozni
            //A szótár kulcsa a könyv leltári száma
            //A szótár értéke a könyvnek a listában szereplő indexe

            KonyvesPolc konyvesPolc = new KonyvesPolc();
            try
            {
                Konyv konyv1 = new Konyv("12kk5d78911", "0836566688", "Valak000", "A asdadssad", 2021, "Magyar", true, 'n');
                Konyv konyv2 = new Konyv("123456r789l", "7097687932", "Petőfi Sánydor", "Szkubiduou", 2012, "Magyar", true, 'i');
                Konyv konyv3 = new Konyv("sdjkhnfg334", "4262495213", "József Atyi", "Némónak nem a nyomában", 2004, "Magyar", true, 'n');
                Konyv konyv4 = new Konyv("84375dfkkkd", "0544051904", "Orbán Viktor", "Háborús történeteim", 2023, "Magyar", true, 'i');

                konyvesPolc.addKonyv(konyv1);
                konyvesPolc.addKonyv(konyv2);
                konyvesPolc.addKonyv(konyv3);
                konyvesPolc.addKonyv(konyv4);
            }
            catch(AccessionNumberLength e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ISBN_NumberLengthException e)
            {
                Console.WriteLine(e.Message);
            } catch (ISBN_NumberFormatException e)
            {
                Console.WriteLine(e.Message);
            } catch(AuthorNameLengthException e)
            {
                Console.WriteLine(e.Message);
            } catch (TitleLengthException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (BookEditionYearException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (EmptyLanguageNotAllowedException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (EncyclopediaRequiredException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (EbookFormatException e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (var item in konyvesPolc.getKonyvesPolc())
            {
                konyvesPolc.addKonyvToDict(item.LeltariSzam ,konyvesPolc.getBookIndex(item));
            }

            foreach(var item in konyvesPolc.getKonyvesDict())
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
