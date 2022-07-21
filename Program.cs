using System;
namespace AlanHesaplama
{
    struct Program
    {
        static void Main(string[] args)
        {            
            i:
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz..:(1-3)");
            Console.WriteLine("Alan     Hesaplamak İçin =>    (1)");
            Console.WriteLine("Çevre    Hesaplamak İçin =>    (2)");
            Console.WriteLine("Hacim    Hesaplamak İçin =>    (3)");
            int choice=int.Parse(Console.ReadLine());
            if (choice>0 && choice<4)
            {
                switch (choice)
                {
                    case 1 : 
                            AreaCalculator area= new AreaCalculator();
                            c:
                            Console.WriteLine("Aşağıdakilerden Hangisinin alanını Hesaplamak istersiniz..:");
                            Console.WriteLine("Daire..     => (1)");
                            Console.WriteLine("Kare        => (2)");
                            Console.WriteLine("Üçgen       => (3)");
                            Console.WriteLine("Dikdörtgen  => (4)");
                            int choiceShape=int.Parse(Console.ReadLine());
                            if (choiceShape<5 && choiceShape>0)
                            {
                                switch (choiceShape)
                                {
                                    case 1 : 
                                            Console.WriteLine(area.Daire());
                                    break;
                                    case 2 : 
                                            Console.WriteLine(area.Kare());
                                    break;
                                    case 3 : 
                                            Console.WriteLine(area.Ucgen());
                                    break;
                                    case 4 : 
                                            Console.WriteLine(area.Dikdortgen());
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lütfen Aralıkta bir sayı giriniz");
                                goto c;
                            }
                            break;
                    case 2 : 
                            PerimeterCalculator peri=new PerimeterCalculator();
                            b:
                             Console.WriteLine("Aşağıdakilerden Hangisinin Çevresini Hesaplamak istersiniz..:");
                            Console.WriteLine("Daire..     => (1)");
                            Console.WriteLine("Kare        => (2)");
                            Console.WriteLine("Üçgen       => (3)");
                            Console.WriteLine("Dikdörtgen  => (4)");
                             choiceShape=int.Parse(Console.ReadLine());
                            if (choiceShape<5 && choiceShape>0)
                            {
                                switch (choiceShape)
                                {
                                    case 1 : 
                                            Console.WriteLine(peri.Daire());
                                    break;
                                    case 2 : 
                                            Console.WriteLine(peri.Kare());
                                    break;
                                    case 3 : 
                                            Console.WriteLine(peri.Ucgen());
                                    break;
                                    case 4 : 
                                            Console.WriteLine(peri.Dikdortgen());
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lütfen Aralıkta bir sayı giriniz");
                                goto b;
                            }
                            break;
                    case 3 : 
                            BulkCalculator bulk= new BulkCalculator(); 
                            a:
                            Console.WriteLine("Aşağıdakilerden Hangisinin Hacmini Hesaplamak istersiniz..:");
                            Console.WriteLine("Daire..     => (1)");
                            Console.WriteLine("Kare        => (2)");
                            Console.WriteLine("Üçgen       => (3)");
                            Console.WriteLine("Dikdörtgen  => (4)");
                             choiceShape=int.Parse(Console.ReadLine());
                            if (choiceShape<5 && choiceShape>0)
                            {
                                switch (choiceShape)
                                {
                                    case 1 : 
                                            Console.WriteLine(bulk.Daire());
                                    break;
                                    case 2 : 
                                            Console.WriteLine(bulk.Kare());
                                    break;
                                    case 3 : 
                                            Console.WriteLine(bulk.Ucgen());
                                    break;
                                    case 4 : 
                                            Console.WriteLine(bulk.Dikdortgen());
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lütfen Aralıkta bir sayı giriniz");
                                goto a;
                            }
                            break;
                    

                   
                }
            }
            else
            {
                Console.WriteLine("Lütfen Doğru Rakamı Giriniz...");
                goto i;
            }
        }
    }
}