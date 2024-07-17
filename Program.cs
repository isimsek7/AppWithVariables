class Program
{
    public string adSoyad;     //Numara iceren verilerde olasi bir harf islenmesi durmunda exception vermesi icin ve int kucuk geldigi icin
    public string ad;          //tc ve tel numaralarini double kullandim.
    public string soyad;
    public double tc;
    public double tel;
    public decimal patikaPuan; //Kusuratli sayilarla da yapilabilinecek islemlerde dogruluk istikrari icin                            
    public decimal ilkHarcama; //para ile ilgili degerlerin hepsini decimallere atadim.
    public decimal ikinciHarcama;
    public decimal toplamHarcama;

    static void Main(string[] args)
    {
        Console.WriteLine("Lutfen asagidaki bilgileri giriniz:");       // Dili dusundurmemek icin ne olur ne olmaz readline() girilen verileri
        Console.Write("T.C Numarasi: ");                                // tanimlanan veri turune donusturerek atadim.                         
        double tc = Convert.ToDouble(Console.ReadLine());
        Console.Write("Adiniz: ");
        string ad= Console.ReadLine();
        Console.Write("Soyadiniz: ");
        string soyad=Console.ReadLine();
        Console.Write("Telefon numarasi: ");
        double tel = Convert.ToDouble(Console.ReadLine());
        Console.Write("Yas: ");
        int yas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ilk aldiginiz urunun fiyati: ");
        decimal ilkHarcama = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ikinci aldiginiz urunun fiyati: ");
        decimal ikinciHarcama = Convert.ToDecimal(Console.ReadLine());
        decimal toplamHarcama = ilkHarcama + ikinciHarcama;
        decimal patikaPuan = ((toplamHarcama * 10) / 100);
        Console.WriteLine("\n----------------------------------------------------");
        string adSoyad = ad + " " + soyad;
        Console.WriteLine("{0} T.C Numarali, {1} kisisi icin kayit olusturulmustur.", tc, adSoyad);
        Console.WriteLine("{0} numarasina, bildirim mesaji gonderilmistir.", tel);
        Console.WriteLine("{0} toplam harcama karsiligi kazanilan %10 Patika puan miktari -> {1}TL'dir.", toplamHarcama, patikaPuan);

        



        














    }

    
}

