using System;

namespace Inheritance_Kalıtım
{
    public class Bitkiler:Canlilar
    {
        public void FotonsentezYapmak()
        {
            Console.WriteLine("Bitkiler Fotosentez Yapar.");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public void TohumluCogalma()
        {
            Console.WriteLine("Tohumlu Bitkiler Tohumla Çoğalır.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
         public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz Bitkiler Sporla Çoğalır.");
        }
    }
}