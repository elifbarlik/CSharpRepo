using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Murat";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("**** Restoran Menü Fiyatı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            //Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            //Console.WriteLine("-----Kola: " + cokePrice + " TL");
            //Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            //Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            //Console.WriteLine("-----Su: " + waterPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("**** Restoran Menü Fiyatı ****");


            //Console.WriteLine();
            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalHamgurgerPrice;
            //int totalCokePrice;
            //int totalWaterPrice;
            //int totalFriesPrice;
            //int totalPizzaPrice;
            //int totalLemonadePrice;

            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
            //totalCokePrice = cokeCount * cokePrice;
            //totalWaterPrice = waterCount * waterPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;
            //totalFriesPrice = friesCount * friesPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;

            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Hamburger Tutarı: " + totalHamgurgerPrice + " TL");
            //Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            //Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            //Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            //Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            //Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            //Console.WriteLine();

            //int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //"  ' 

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber +  " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " "  + passengerDistrict  + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " +  totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
