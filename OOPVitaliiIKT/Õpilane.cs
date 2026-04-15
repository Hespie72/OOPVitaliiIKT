using System;
using System.Collections.Generic;
using System.Text;

namespace OOPVitaliiIKT
{
    // Õpilane pärib klassist Isik
    public enum Õppevorm
    {
        Päevane,
        Kaugõpe,
        Ekstern,
        AkadeemilinePuhkus
    }
    public class Õpilane : Isik, ITööline
    {
        public string Kool { get; set; }
        public int Klass { get; set; }
        public Õppevorm Staatus { get; set; } = Õppevorm.Päevane;
        public double KeskmineHinne { get; set; }
        public int Puudumised { get; set; } = 0;
        public bool KasOnSotsTõend { get; set; } = false;
        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Toetus;
        public override void Kirjelda()
        {
            Console.WriteLine($"{Nimi} õpib {Klass}. klassis. Vorm: {Staatus}");
        }

        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }
        public double ArvutaPalk()
        {
            double põhitoetus = 0;
            double eritoetus = 0;
            if (KeskmineHinne >= 3.8 && Puudumised < 30)
            {
                põhitoetus =+60;
            }
            if (KasOnSotsTõend)
            {
                eritoetus = +120;
            }
            return põhitoetus + eritoetus;
        }

    }
}
