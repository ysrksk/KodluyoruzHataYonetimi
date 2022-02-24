using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Bir Sayi Giriniz;");
                int sayi = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Girmiş olduğunuz sayi:" + sayi);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Hata:" + ex.Message.ToString());
                
            }
            /*finally
            {
                System.Console.WriteLine("İşlme tamalandı.");
            }*/

            try
            {
                int a = int.Parse(null);
            }
            catch(ArgumentException ex)
            {
                System.Console.WriteLine("Boş değer girdiniz");
                System.Console.WriteLine(ex);

            }
            catch(FormatException ex)
            {
                System.Console.WriteLine("Veri tipi uygun değil.");
                System.Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                System.Console.WriteLine("Çok küçük yada çok büyül bi değer girdiniz.");
                System.Console.WriteLine(ex);
            }
            finally
            {
                System.Console.WriteLine("İşlem başarıyla tamamlandı");
            }
        }
    }
}
