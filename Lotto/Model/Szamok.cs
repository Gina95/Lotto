using Lotto.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    public class Szamok

    {
        public Szamok()
        {
        }

        public Szamok(string[] beolvasottSzamokSzoveg)
        {
            if (beolvasottSzamokSzoveg.Length == 7)
            {

                HashSet<int> halmaz = new HashSet<int>();
                for (int i = 0; i < 7; i++)
                {
                    try
                    {
                        int szam = Convert.ToInt32(beolvasottSzamokSzoveg[i]);

                        if ((szam < 1) || (szam > 35))
                        {
                            throw new ArgumentException("Line error", "sor");
                        }

                        halmaz.Add(szam);
                    }
                    catch (Exception)
                    {
                        throw new ArgumentException("Line error", "sor");
                    }                             
                }



                if (halmaz.Count() != 7)
                {
                    throw new ArgumentException("Line error", "sor");
                }

                Szam1 = halmaz.ElementAt(0);
                Szam2 = halmaz.ElementAt(1);
                Szam3 = halmaz.ElementAt(2);
                Szam4 = halmaz.ElementAt(3);
                Szam5 = halmaz.ElementAt(4);
                Szam6 = halmaz.ElementAt(5);
                Szam7 = halmaz.ElementAt(6);
            }
            else
            {
                throw new ArgumentException("hibas sor");
            }
        }

        public Szamok(HashSet<int> gerenraltSzamok)
        {
            Szam1 = gerenraltSzamok.ElementAt(0);
            Szam2 = gerenraltSzamok.ElementAt(1);
            Szam3 = gerenraltSzamok.ElementAt(2);
            Szam4 = gerenraltSzamok.ElementAt(3);
            Szam5 = gerenraltSzamok.ElementAt(4);
            Szam6 = gerenraltSzamok.ElementAt(5);
            Szam7 = gerenraltSzamok.ElementAt(6);
        }

        public int Id { get; set; }
        public int Szam1 { get; set; }
        public int Szam2 { get; set; }
        public int Szam3 { get; set; }

        public int Szam4 { get; set; }

        public int Szam5 { get; set; }

        public int Szam6 { get; set; }

        public int Szam7 { get; set; }

    }
}
