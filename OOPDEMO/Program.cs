using System.Globalization;

namespace OOPDEMO
{
    internal class Program
    {
        static BilgisayarKasasi _bs;
        static void Main(string[] args)
        {
            PCOlustur();
            PCGoster();
            
            
        }
        static void PCOlustur()
        {
            Console.Write("Ana Kart: ");
            string anaKart = Console.ReadLine();
            Console.Write("(Ekran Kartı Tipi (" + EkranKartiTipleri.AMD + ": " + (int)EkranKartiTipleri.AMD + ", "
                + EkranKartiTipleri.NVIDIA + ": " + (int)EkranKartiTipleri.NVIDIA + ")");
            string ekranKartiTipiInput = Console.ReadLine();
            int ekranKartiTipi = Convert.ToInt32(ekranKartiTipiInput);

            Console.Write("(İşlemci Tipi ("
                + IslemciTipleri.i3 + ": " + (int)IslemciTipleri.i3 + ", "
                + IslemciTipleri.i5 + ": " + (int)IslemciTipleri.i5 + ", "
                + IslemciTipleri.i7 + ": " + (int)IslemciTipleri.i7 + ", "
                + IslemciTipleri.i9 + ": " + (int)IslemciTipleri.i9 +
                ")");
            string islemciTipiInput = Console.ReadLine();
            int islemciTipi = Convert.ToInt32(islemciTipiInput);
            Console.Write("HDD Boyutu Giriniz (MB): ");
            int hDD = int.Parse(Console.ReadLine());
            Console.Write("SSD Boyutu Giriniz (MB): ");
            int sSD = int.Parse(Console.ReadLine());
            Console.Write("Power Suply Gücünü Giriniz (Watt): ");
            short powerSuply = short.Parse(Console.ReadLine());
            Console.Write("RAM Boyutu Giriniz (MHZ): ");
            short ram = short.Parse(Console.ReadLine());
            Console.Write("Alım Tarihi Giriniz (dd.mm.yyyy): ");
            DateTime alimTarihi = DateTime.Parse(Console.ReadLine(), new CultureInfo("tr-TR"));
            string kasa = Console.ReadLine();

            _bs = new BilgisayarKasasi()
            {
                AlimTarihi = alimTarihi,
                PowerSuply = powerSuply,
                Ram = ram,
                AnaKart = anaKart,
                SSD = sSD,
                HDD = hDD,
                IslemciTipi = (IslemciTipleri)islemciTipi,
                EkranKartiTipi = (EkranKartiTipleri)ekranKartiTipi,
                Kasa = kasa

            };



        }
        static void PCGoster()
        {
           

            Console.WriteLine("*** Oluşturulan Bilgisayar ***");

            Console.WriteLine(
                $"Kasa: {_bs.Kasa} \n" +
                $"Ana Kart: {_bs.AnaKart} \n" +
                $"Power Suply: {_bs.PowerSuply} \n" +
                $"HDD: {_bs.HDD} MB \n" +
                $"SSD: {_bs.SSD} MB \n" +
                $"RAM: {_bs.Ram} MHZ \n" +
                $"Alım Tarihi {_bs.AlimTarihi.ToString("dd.MM.yyyy", new CultureInfo("tr-TR"))}: \n" +
                $"İşlemci Tipi: {_bs.IslemciTipi}({(int)_bs.IslemciTipi}) \n" +
                $"Ekran Kartı Tipi: {_bs.EkranKartiTipi}({(int)_bs.EkranKartiTipi}) ");





        }
    }
}