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
            Isik inimene1 = new Isik();
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

            Console.WriteLine("\n --- Õpilase andmed ---");
            Õpilane õpilane1 = new Õpilane();
            õpilane1.Nimi = "Oleg";
            õpilane1.Sünniaasta = 2009;
            õpilane1.Kool = "Tallinna Tööstushariduskeskus";
            õpilane1.Klass = 10;
            õpilane1.Tervita();
            õpilane1.Õpi();
            Console.ReadLine();
        }
    }
}