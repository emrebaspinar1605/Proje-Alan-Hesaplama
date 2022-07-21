using System;

namespace AlanHesaplama
{
    public class BulkCalculator
    {
        public double Daire()
        {
            Console.WriteLine("Lütfen yarıçapı giriniz..: ");
            int r=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Yükseklik giriniz giriniz..: ");
            int h=int.Parse(Console.ReadLine());
            return Math.PI*h*r/4;
        }
        public int Dikdortgen()
        {
            Console.WriteLine("Lütfen uzun kenarı giriniz..: ");
            int uzun=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen kısa kenarı giriniz..: ");
            int kisa=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Yükseklik giriniz..: ");
            int h=int.Parse(Console.ReadLine());
            return uzun*kisa*h;
        }
        public int Ucgen()
        {
            Console.WriteLine("Lütfen dik Kenarı giriniz..: ");
            int dik=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Yan kenarı giriniz..: ");
            int yan=int.Parse(Console.ReadLine());
            return dik*yan/2;
        }
        public int Kare()
        {
            Console.WriteLine("Lütfen uzun kenarı giriniz..: ");
            int kenar=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen yükseklik giriniz..: ");
            int h=int.Parse(Console.ReadLine());
            return kenar*kenar*h;
        }
    }
}