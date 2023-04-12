using Osztaly_Konyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Osztaly_Konyv
{
    public class Konyv
    {
        //isbnSzam
        //Szerző(k)
        //Mű címe
        //kiadási éve
        //nyelv
        //enciklopédia vagy nem? bool
        //ebook i/n - char
        private string leltariSzam;
        private string isbnSzam;
        private string szerzo;
        private string cim;
        private int kiadasEv;
        private string nyelv;
        private bool enciklopediae;
        private char ebook;
        private Random rand = new Random();

        public Konyv()
        {

        }

        public Konyv(string leltariSzam, string isbnSzam, string szerzo, string cim, int kiadasEv, string nyelv, bool enciklopediae, char ebook)
        {
            LeltariSzam = leltariSzam;
            IsbnSzam = isbnSzam;
            Szerzo = szerzo;
            Cim = cim;
            KiadasEv = kiadasEv;
            Nyelv = nyelv;
            Enciklopediae = enciklopediae;
            Ebook = ebook;
        }

        public override string ToString()
        {
            return $"Leltári szám: {leltariSzam}, ISBN szám: {isbnSzam}, Szerző: {szerzo}, Cím: {cim}, Kiadás éve: {kiadasEv}, Nyelv: {nyelv}, Enciklopédia-e: {enciklopediae}, E-book-e: {ebook}";
        }
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

        public string IsbnSzam
        {
            get => isbnSzam;
            set
            {
                if (value.Length != 10 && value.Length != 13)
                {
                    throw new ISBN_NumberLengthException(value.Length);
                }
                switch (value.Length)
                {
                    case 10:
                        //2. tipus
                        int szam = 0;
                        int n = 1;
                        for (int i = 0; i < 9; i++)
                        {
                            szam += n * int.Parse(value[i].ToString());
                            n++;
                        }
                        if (szam % 11 != int.Parse(value[9].ToString()))
                        {
                            throw new ISBN_NumberFormatException();
                        }
                        #region //1. tipus
                        /*int szam3 = 0;
                        int n3 = 10;
                        int oszto = 0;
                        for (int i = 0; i < 9; i++)
                        {
                            if(n3 >= 2 && n3 <= 10)
                            {
                                szam3 += n3 * int.Parse(value[i].ToString());
                                n3--; 
                            }
                        }
                        while ((oszto * 11) < szam3)
                        {
                            oszto++;
                        }
                        if ((oszto * 11) - szam3 != int.Parse(value[9].ToString()))
                        {
                            throw new ISBN_NumberFormatException();
                        }*/
                        #endregion
                        break;
                    case 13:
                        int szam2 = 0;
                        int n2;
                        for (int i = 0; i < 12; i++)
                        {
                            if (i % 2 == 0)
                            {
                                n2 = 1;
                                szam2 += n2 * int.Parse(value[i].ToString());
                            }
                            else
                            {
                                n2 = 3;
                                szam2 += n2 * int.Parse(value[i].ToString());
                            }
                        }
                        if (szam2 % 10 != int.Parse(value[12].ToString()))
                        {
                            throw new ISBN_NumberFormatException();
                        }

                        break;
                    default:
                        break;
                }
                isbnSzam = value;

            }
        }
        ~Konyv()
        {
            Console.WriteLine("DESTRUKTOR CSSSSSSSSSSSSSSS");
        }
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
        public string Szerzo
        {
            get => szerzo;

            set
            {
                if (value.Length < 6)
                {
                    throw new AuthorNameLengthException();
                }
                szerzo = value;
            }

        }
        public string Cim
        {
            get => cim;
            set
            {
                if (value.Length < 1)
                {
                    throw new TitleLengthException();
                }
                cim = value;
            }
        }
        public int KiadasEv
        {
            get => kiadasEv;
            set
            {
                if (value < -10000 || value > 2023)
                {
                    throw new BookEditionYearException();
                }
                kiadasEv = value;
            }
        }
        public string Nyelv
        {
            get => nyelv;
            set
            {
                if (value == null || value.Length <= 0)
                {
                    throw new EmptyLanguageNotAllowedException();
                }
                nyelv = value;
            }

        }
        public bool Enciklopediae
        {
            get => enciklopediae;
            set
            {
                if (value != true && value != false)
                {

                    throw new EncyclopediaRequiredException();
                }
                enciklopediae = value;
            }
        }
        public char Ebook
        {
            get => ebook;
            set
            {
                if (value != 'i' && value != 'n')
                {
                    throw new EbookFormatException();
                }
                ebook = value;
            }
        }
        public string LeltariSzam
        {
            get => leltariSzam;
            set
            {
                if(value.Length != 11)
                {
                    throw new AccessionNumberLength();
                }
                leltariSzam = value;
            }
        }
    }
}
