using System;
using System.Data.SqlTypes;
using System.Security.Cryptography;
namespace programone
{
    class Operation
    {

        Costumer c1 = new Costumer();

        public void moneyDeposit()
        {
            System.Console.WriteLine("Ne kadar para eklemek istiyorsunuz ? ");
            double tutar = Convert.ToInt32(Console.ReadLine());
            c1.Balance += tutar;
        }
        public void moneyDraw()
        {
            System.Console.WriteLine("Ne kadar para çekmek istiyorsunuz ? \n");
            double tutar = Convert.ToInt32(Console.ReadLine());
            c1.Balance -= tutar;
        }
        public void showBalance()
        {
            System.Console.WriteLine(c1.Balance);
        }
        public void faizGetirisi()
        {
            System.Console.WriteLine("1 yıllık vade ile Ne kadar para yatırmak istiyorsunuz");
            double tutar = Convert.ToInt32(Console.ReadLine());
            double kazanc = tutar * 0.6;
            System.Console.WriteLine(tutar + " yatırırsanız 1 yıl sonra kârınız  = " + kazanc);
        }
        // faizGetirisi fonksiyonun overload edilmiş hali ( geriye değer döndüren hali)
        public double faizKazanci()
        {
            System.Console.WriteLine("1 yıllık vade ile Ne kadar para yatırmak istiyorsunuz");
            double tutar = Convert.ToInt32(Console.ReadLine());
            if (tutar <= c1.Balance && tutar > 0)
            {
                double kazanc = tutar * 0.6;
                return kazanc;
            }
            else{
                System.Console.WriteLine("Bakiyeniz yetersiz ");
                return 0; 
            }

        }
        public void krediHesaplama()
        {
            System.Console.WriteLine("1 yıllık vade ile Ne kadar borç istiyorsunuz");
            double tutar = Convert.ToInt32(Console.ReadLine());
            double faizBorcu = tutar * 0.7;
            System.Console.WriteLine(tutar + " karşılığında 1 yıl sonunda faiz tutarı = " + faizBorcu + "Toplam borç = "+(tutar+faizBorcu));

        }
        public double krediTutar()
        {
            System.Console.WriteLine("1 yıllık vade ile Ne kadar borç istiyorsunuz");
            double tutar = Convert.ToInt32(Console.ReadLine());
            double borç = tutar * 0.7;
            return borç;
        }
        public void faizKoy()
        {
            faizGetirisi(); // bilgilendirme için 
            System.Console.WriteLine("Devam etmek istiyorsanız 1 e vazgeçmek için 0 a basınız.\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                // 1 yıl sonraki tutar
                c1.Balance += faizKazanci();
            }
            else if (choice == 0) Environment.Exit(0);
            else
            {
                System.Console.WriteLine("Yanlış değer girdiniz tekrar deneyiniz");
                return;
            }
        }
        public void krediÇek()
        {
            krediHesaplama(); // bilgilendirme için 
            System.Console.WriteLine("Devam etmek istiyorsanız 1 e vazgeçmek için 0 a basınız.\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                // 1 yıl sonraki tutar
                c1.Balance -= krediTutar();
            }
            else if (choice == 0) Environment.Exit(0);
            else
            {
                System.Console.WriteLine("Yanlış değer girdiniz tekrar deneyiniz");
                return;
            }
        }
    }
}
// para çekme, para yükleme, transfer, hesap bakiyesi görüntüleme, yeni hesap açma.