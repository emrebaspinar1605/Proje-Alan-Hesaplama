using System;

namespace AlanHesaplama
{
    public class PerimeterCalculator
    {
        public double Daire()
        {
            Console.WriteLine("Lütfen YarıÇap giriniz..: ");
            double r=double.Parse(Console.ReadLine());
            return 2*Math.PI*r;
        }
        public int Kare()
        {
            Console.WriteLine("Lütfen bir kenar giriniz..: ");
            int kenar=int.Parse(Console.ReadLine());
            return kenar*4;
        }
        public int Dikdortgen()
        {
            Console.WriteLine("Lütfen uzun kenarı giriniz..: ");
            int uzun=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen kısa Kenarı giriniz..: ");
            int kisa=int.Parse(Console.ReadLine());
            return (kisa+uzun)*2;
        }
        public double Ucgen()
        {
             Console.WriteLine("Lütfen Karşı kenarı giriniz..: ");
            int karsi=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Komşu Kenarı giriniz..: ");
            int komsu=int.Parse(Console.ReadLine());
            int kokhipotenus=(karsi*karsi)+(komsu*komsu);
            double hipotenus=Math.Sqrt(kokhipotenus);
            return karsi+komsu+hipotenus;
        }
    }
}