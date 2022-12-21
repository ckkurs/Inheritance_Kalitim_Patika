using System;

namespace Inheritance_Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
         //                 CANLILAR
        //                      |
        //        BİTKİLER              HAYVANLAR
        //     |            |            |           |
        //  TOHUMLU      TOHUMSUZ     SÜRÜNGENLER   KUŞLAR

        TohumluBitkiler tohumluBitki = new TohumluBitkiler();
        tohumluBitki.Beslenme();
        tohumluBitki.Solunum();
        tohumluBitki.Bosaltim();
        tohumluBitki.FotonsentezYapmak();
        tohumluBitki.TohumluCogalma();

        Console.WriteLine("+*+*+*+*+*+*+*+*+*+*+*+*+*");

        Kuslar martı=new Kuslar();
        martı.Solunum();
        martı.Beslenme();
        martı.Bosaltim();
        martı.Adaptasyon();
        martı.Uçmak();

        }
    }
}
