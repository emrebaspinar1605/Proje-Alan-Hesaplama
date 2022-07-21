using System;
namespace AlanHesaplama
{
    public class AreaCalculator 
    {
        public double Daire()
        {
            Console.WriteLine("Lütfen YarıÇap giriniz..: ");
            double r=double.Parse(Console.ReadLine());
            return Math.PI*r*r;
        }
        public int Ucgen()
        {
            Console.WriteLine("Lütfen Karşı kenarı giriniz..: ");
            int karsi=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Komşu Kenarı giriniz..: ");
            int komsu=int.Parse(Console.ReadLine());
            return (karsi*komsu)/2;

        }
        public int Dikdortgen()
        {
            Console.WriteLine("Lütfen uzun kenarı giriniz..: ");
            int uzun=int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen kısa Kenarı giriniz..: ");
            int kisa=int.Parse(Console.ReadLine());
            return uzun*kisa;
        }
        public int Kare()
        {
            Console.WriteLine("Lütfen Kenar giriniz");
            int kenar=int.Parse(Console.ReadLine());
            return kenar*kenar;
        }
    }
}