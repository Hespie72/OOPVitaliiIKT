using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace OOPVitaliiIKT
{
    public class StartPage
    {
        public static void Main()
        {

            /*Isik inimene1 = new Isik();
            inimene1.Nimi = "Mati";
            inimene1.Sünniaasta = 1991;
            inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...
            Console.WriteLine("\n --- Õpetaja andmed --- ");
            Õpetaja õpetaja1 = new Õpetaja();
            õpetaja1.Nimi = "Marina";
            õpetaja1.Sünniaasta = 1979;
            õpetaja1.Aine = "programmerimine";
            õpetaja1.Tervita();
            õpetaja1.Õpeta();
            õpetaja1.ArvutaPalk();

            Console.WriteLine("\n --- Õpilase andmed ---");
            Õpilane õpilane1 = new Õpilane();
            õpilane1.Nimi = "Oleg";
            õpilane1.Sünniaasta = 2009;
            õpilane1.Kool = "Tallinna Tööstushariduskeskus";
            õpilane1.Klass = 10;
            õpilane1.KasOnSotsTõend = true;
            õpilane1.KeskmineHinne = 4.2;
            õpilane1.Puudumised = 14;
            õpilane1.Tervita();
            õpilane1.Õpi();
            õpilane1.ArvutaPalk();
            Console.ReadLine();*/
            List<ITööline> palgasaajad = new List<ITööline>();
            /*

            //palgasaajad.Add(mati);
            //
            //palgasaajad.Add(danil);

            palgasaajad.AddRange(new ITööline[] { mati, irina, vladislav, danil });

            Console.WriteLine("--- Väljamaksed ---");
            foreach (ITööline isik in palgasaajad)
            {
                Console.WriteLine($"Väljamakse summa: {isik.ArvutaPalk()} eurot. {((Isik)isik).Nimi}le");
            }*/

            Õpetaja irina = new Õpetaja { Nimi = "Irina", Aine = "C#", Tunnitasu = 6.50, Tunnidkuus = 280 };
            Õpetaja vladislav = new Õpetaja { Nimi = "Vladislav", Aine = "Pythone", Tunnitasu = 6.50, Tunnidkuus = 280 };
            palgasaajad.Add(irina);
            palgasaajad.Add(vladislav);
            Random rnd = new Random();
            string[] nimed = { "Kiriil", "Yurii", "Matvei", "Timofey", "Artem" };
            Õppevorm[] vormid = (Õppevorm[])Enum.GetValues(typeof(Õppevorm));
            for (int i = 0; i < nimed.Length; i++)
            {
                Õpilane õpilane = new Õpilane
                {
                    Nimi = nimed[rnd.Next(nimed.Length)],
                    Klass = rnd.Next(1, 13),
                    Kool = "TTHK",
                    KeskmineHinne = rnd.NextDouble() * 5,
                    Puudumised = rnd.Next(0, 350),
                    KasOnSotsTõend = rnd.Next(0, 2) == 1,
                    Staatus = vormid[rnd.Next(vormid.Length)]
                };
                palgasaajad.Add(õpilane);
                foreach (ITööline isik in palgasaajad)
                {
                    string tüüp = isik.VäljamakseTüüp.ToString().ToLower();
                    Console.WriteLine($"{tüüp} summa: {isik.ArvutaPalk()} eurot. {((Isik)isik).Nimi}le");
                    õpilane.Kirjelda();
                }
            }
            List<Koolihaldus> list = new List<Koolihaldus>();
            Õpilane mati = new Õpilane { Nimi = "Mati", Klass = 9, Kool = "Kutsehariduskeskus", KeskmineHinne = 4.0, Puudumised = 20, KasOnSotsTõend = true };
            Õpilane danil = new Õpilane { Nimi = "Daniil", Klass = 10, Kool = "Kutsehariduskeskus", KeskmineHinne = 3.5, KasOnSotsTõend = true };
            Koolihaldus minuKool = new Koolihaldus();

            Õpetaja op = new Õpetaja { Nimi = "Mati", Aine = "Programmeerimine" };
            Õpilane opilane1 = new Õpilane { Nimi = "Mari", Klass = 10, Staatus = Õppevorm.Päevane };

            
            minuKool.LisaInimene(op);
            minuKool.LisaInimene(opilane1);
            minuKool.LisaInimene(irina);
            minuKool.LisaInimene(vladislav);
            minuKool.LisaInimene(mati);
            minuKool.LisaInimene(danil);

            minuKool.KuvaKõik();
        }
    }
}