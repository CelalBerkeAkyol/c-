using System;
namespace programone
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Merhaba Akyol Bank'a hoşgeldiniz");
            System.Console.WriteLine("Lütfen Adınızı giriniz");
            String name = Console.ReadLine();
            System.Console.WriteLine("Soy adınızı giriniz");
            String lastName = Console.ReadLine();
            System.Console.WriteLine("Annenizin kızlık soy adı nedir ? ");
            String motherName = Console.ReadLine();
            System.Console.WriteLine("Mesleğiniz nedir");
            String job = Console.ReadLine();
            System.Console.WriteLine("Yaşınız ? ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("İd ? ");
            int id = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Cinsiyetiniz ?");
            Char gender = Convert.ToChar(Console.ReadLine());
            // bilgiler dahilinde yeni nesne oluşturuldu 
            Person c1 = new Person(name, lastName, motherName, job, age, id, gender);
            Operation islem = new Operation();
            // işlemler yapılacak 

            while (true)
            {
                System.Console.WriteLine("Ne yapmak istersiniz");
                System.Console.WriteLine("[0] = programdan çık\n [1] = bakiye göster \n [2] = Hesaba para eklemek \n [3] = Hesaptan para çekmek \n [4] = Faiz getirisi hesapla \n [5] = Faize para koy \n [6] = Kredi hesaplama \n[7] = kredi çek \n ");
                int p1Choice = Convert.ToInt32(Console.ReadLine());
                switch (p1Choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        islem.showBalance();
                        break;
                    case 2:
                        islem.moneyDeposit();
                        break;
                    case 3:
                        islem.moneyDraw();
                    break;    
                     case 4:
                        islem.faizGetirisi();
                    break;  
                     case 5:
                        islem.faizKoy();
                    break;  
                     case 6:
                        islem.krediHesaplama();
                    break;  
                     case 7:
                        islem.krediÇek();
                    break;  
                   

                }

            }
        }
    }

}