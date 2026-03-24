using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brutto_Netto_Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rvBeitrag = 0, kvBeitrag = 0, alvBeitrag = 0, pvBeitrag = 0;
            double Lohnsteuer = 0, Kirchensteuer = 0;
            double Jahresgehalt = 0, Monatsgehalt = 0, Kinder = 0, Nettobetrag = 0;
            string GehaltsArt;
            double GesamtAbzüge = 0;
            double y = 0, z = 0;
            string auswahl;

            do
            {

                do
                {
                    Console.WriteLine("Möchten Sie ihr Jahresgehalt oder Monatsgehalt eingeben?");
                    Console.WriteLine("Jahresgehalt(1)");
                    Console.WriteLine("Monatsgehalt(2)");                                              
                    Console.WriteLine("Beenden (3)");
                    GehaltsArt = Console.ReadLine();


                    if (GehaltsArt != "1" && GehaltsArt != "2" && GehaltsArt != "3")

                    {

                        Console.WriteLine("Fehlerhafte Eingabe");

                        Console.ReadLine();

                        Console.Clear();

                    }
                }  while (GehaltsArt != "1" && GehaltsArt != "2" && GehaltsArt != "3");


                if (GehaltsArt != "3")
                {
                    if (GehaltsArt == "1")
                    {


                        Console.WriteLine("Wie viel verdienen Sie jährlich?");
                        Jahresgehalt = Convert.ToDouble(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Fehlerhafte Eingabe");
                            Console.WriteLine("Wie viel verdienen Sie jährlich?");
                            Jahresgehalt = Convert.ToDouble(Console.ReadLine());
                        } while (Jahresgehalt < 0);
                    }

                    if (GehaltsArt == "2")
                    {
                        Console.WriteLine("Wie viel verdienen Sie monatlich?");
                        Monatsgehalt = Convert.ToDouble(Console.ReadLine());
                        Jahresgehalt = Monatsgehalt * 12;

                        do
                        {
                            Console.WriteLine("Fehlerhafte Eingabe");
                            Console.WriteLine("Wie viel verdienen Sie monatlich?");
                            Monatsgehalt = Convert.ToDouble(Console.ReadLine());
                            Jahresgehalt = Monatsgehalt * 12;
                        } while (Jahresgehalt < 0);
                    }

                    rvBeitrag = Jahresgehalt * 9.3 / 100;

                    if (Jahresgehalt > 90600)
                    {
                        rvBeitrag = 90600 * 9.3 / 100;
                    }

                    alvBeitrag = Jahresgehalt * 2.3 / 100;
                    if (Jahresgehalt > 90600)
                    {
                        alvBeitrag = 90600 * 2.3 / 100;
                    }


                    kvBeitrag = Jahresgehalt * 7.3 / 100;
                    if (Jahresgehalt > 90600)
                    {
                        kvBeitrag = 66150 * 7.3 / 100;
                    }

                    Console.WriteLine("Wie viele Kinder haben Sie?");
                    Kinder = Convert.ToDouble(Console.ReadLine()); 
                    if (Jahresgehalt > 69300)
                    {
                        Console.WriteLine("Sind Sie Privat versichert? Ja(1) Nein(2)");
                        auswahl = Console.ReadLine();
                        if (auswahl == "1")
                        {


                        }

                    }
                    if (Kinder == 0)
                        {

                            pvBeitrag = Jahresgehalt * 0.026;
                            if (Jahresgehalt > 66150)
                            {
                                kvBeitrag = 66150 * 0.026;
                            }
                        }

                        if (Kinder == 1)
                        {

                            pvBeitrag = Jahresgehalt * 0.018;
                            if (Jahresgehalt > 66150)
                            {
                                kvBeitrag = 66150 * 0.018;
                            }
                        }
                        if (Kinder == 2)
                        {

                            pvBeitrag = Jahresgehalt * 0.0155;
                            if (Jahresgehalt > 66150)
                            {
                                kvBeitrag = 66150 * 0.0155;
                            }
                        }
                        if (Kinder == 3)
                        {

                            pvBeitrag = Jahresgehalt * 0.013;
                            if (Jahresgehalt > 66150)
                            {
                                kvBeitrag = 66150 * 0.0;
                            }
                        }
                        if (Kinder == 4)
                        {

                            pvBeitrag = Jahresgehalt * 0.0105;
                            if (Jahresgehalt > 66150)
                            {
                                kvBeitrag = 66150 * 0.026;
                            }
                        }
                        if (Kinder >= 5)
                        {

                            pvBeitrag = Jahresgehalt * 0.008;
                            if (Jahresgehalt > 66150)
                            {
                                kvBeitrag = 66150 * 0.008;
                            }

                        }
                    


                    if (Jahresgehalt > 11784 && Jahresgehalt <= 17005)
                    {
                        y = (Jahresgehalt - 11784) / 10000;
                        Lohnsteuer = (954.80 * y + 1400) * y;

                    }
                    if (Jahresgehalt > 11784)
                    {
                        if (Jahresgehalt > 17005 && Jahresgehalt <= 66760)
                        {
                            z = (Jahresgehalt - 17005) / 10000;
                            Lohnsteuer = (181.19 * z + 2397) * z + 991.21;
                        }

                        if (Jahresgehalt > 66760 && Jahresgehalt <= 277825)
                        {
                            Lohnsteuer = 0.42 * Jahresgehalt - 10636.31;
                        }

                        if (Jahresgehalt > 277825)
                        {

                            Lohnsteuer = 0.45 * Jahresgehalt - 18971.06;
                        }


                        Console.WriteLine("Gehen Sie in die Kirche?");
                        Console.WriteLine("Ja(1)");
                        Console.WriteLine("Nein(2)");
                        auswahl = Console.ReadLine();
                        if (auswahl == "1")
                        {
                            Console.WriteLine("Leben Sie in Bayern oder Baden-Württemberg?");
                            Console.WriteLine("Ja(1)");
                            Console.WriteLine("Nein(2)");
                            auswahl = Console.ReadLine();
                            if (auswahl == "1")
                            {

                                Kirchensteuer = Lohnsteuer * 0.08;
                            }
                            if (auswahl == "2")
                            {
                                Kirchensteuer = Lohnsteuer * 0.09;
                            }
                        }
                    }


                    Nettobetrag = Jahresgehalt - rvBeitrag - alvBeitrag - pvBeitrag - Lohnsteuer - kvBeitrag - Kirchensteuer;
                    Console.Clear();
                    Console.WriteLine("Monatsabzüge:");
                    Console.WriteLine("Rentenversicherung: {0}Euro", Math.Round(rvBeitrag / 12, 2));
                    Console.WriteLine("Arbeitslosenversicherung: {0}Euro", Math.Round(alvBeitrag / 12, 2));
                    Console.WriteLine("Krankenversicherung: {0}Euro", Math.Round(kvBeitrag / 12, 2));
                    Console.WriteLine("Pflegeversicherung: {0}Euro", Math.Round(pvBeitrag / 12, 2));
                    Console.WriteLine("Lohnsteuer: {0}Euro", Math.Round(Lohnsteuer / 12, 2));
                    Console.WriteLine("Kirchensteuer: {0}Euro\n", Math.Round(Kirchensteuer / 12, 2));

                    Console.WriteLine("Jahresabzüge:");
                    Console.WriteLine("Rentenversicherung: {0}Euro", Math.Round(rvBeitrag, 2));
                    Console.WriteLine("Arbeitslosenversicherung: {0}Euro", Math.Round(alvBeitrag, 2));
                    Console.WriteLine("Krankenversicherung: {0}Euro", Math.Round(kvBeitrag, 2));
                    Console.WriteLine("Pflegeversicherung: {0}Euro", Math.Round(pvBeitrag, 2));
                    Console.WriteLine("Lohnsteuer: {0}Euro", Math.Round(Lohnsteuer, 2));
                    Console.WriteLine("Kirchensteuer: {0}Euro\n", Math.Round(Kirchensteuer, 2));

                    Console.WriteLine("Das Jahresnetto beträgt {0}", Math.Round(Nettobetrag, 2));
                    Console.WriteLine("Das Monatssnetto beträgt {0}", Math.Round(Nettobetrag / 12, 2));

                    GesamtAbzüge = rvBeitrag + alvBeitrag + pvBeitrag + Lohnsteuer + kvBeitrag + Kirchensteuer;
                    Console.WriteLine("Sie haben {0} Euro an Steuern gezahlt", Math.Round(GesamtAbzüge, 2));


                }
            } while (GehaltsArt !="3");

        }       
    }

}
