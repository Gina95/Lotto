using Lotto.Data;
using System;
using System.IO;
using System.Linq;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            SzamokDbContext db = new SzamokDbContext();
            if (!db.lottoszamok.Any())
            {
                string[] fajlsorok = File.ReadAllLines(@"D:\gina\gyakorlások\SkandinavLottoSzamok\SkandinavLottoSzamok.csv").Skip(1).ToArray();
                
                foreach (var faljsor in fajlsorok)
                {
                    try {
                        string[] darabolt = faljsor.Split(";");


                        if (darabolt.Length != 16)
                        {
                            throw new ArgumentException("rossz sor");
                        }

                        if (darabolt[darabolt.Length -1] != "")
                        {
                            throw new ArgumentException("rossz sor");
                        }

                        string[] kezi = { darabolt[1], darabolt[2], darabolt[3], darabolt[4], darabolt[5], darabolt[6], darabolt[7] };
                        string[] gepi = { darabolt[8], darabolt[9], darabolt[10], darabolt[11], darabolt[12], darabolt[13], darabolt[14] };
                        Szamok kezisor = new Szamok(kezi);
                        Szamok gepisor = new Szamok(gepi);
                        db.lottoszamok.Add(kezisor);
                        db.lottoszamok.Add(gepisor);
                    }
                    catch (ArgumentException e) 
                    {
                        Console.WriteLine($"Hibás: {faljsor}");
                    }
                }

                int darab = db.SaveChanges();

                Console.WriteLine("sikeresen mentett sorok: " + darab);
            }
            else
            {
                Console.WriteLine("Az adatbázis már fel van töltve");
            }


        }
    }
}
