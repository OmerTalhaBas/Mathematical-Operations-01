class Program
{
    static void Main(string[] args)
    {        
        Console.WriteLine("Birinci Sayıyı Giriniz : ");
        double sayi = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("İkinci Sayıyı Giriniz : ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        MatematikselIslemler(sayi, sayi1);
    }
    static void MatematikselIslemler(double sayi, double sayi1)
    {
        double kare1 = sayi * sayi;
        double kare2 = sayi1 * sayi1;
        Console.WriteLine("Birinci Sayının Karesi : " + kare1);
        Console.WriteLine("İkinci Sayının Karesi : " + kare2);      
        double toplam = sayi + sayi1;
        Console.WriteLine("Sayıların Toplamı : " + toplam);       
        double carpim = sayi * sayi1;
        Console.WriteLine("Sayıların Çarpımı : " + carpim);        
        double kup = sayi * sayi * sayi;
        Console.WriteLine("Birinci Sayının Küpü: " + kup);
    }
}
