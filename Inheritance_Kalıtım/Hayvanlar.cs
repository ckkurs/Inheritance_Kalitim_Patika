using System;

namespace Inheritance_Kalıtım
{
    public class Hayvanlar:Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
    }

    public class Sürüngenler:Hayvanlar
    {
        public void SurunerekHareketEtmek()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public void Uçmak()
        {
            Console.WriteLine("Kuşlar Uçar.");
        }
    }
}