﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("****** Fiyat Lİstesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("____ Elma Birim Fiyatı:" + applePrice);
            //Console.WriteLine("____ Portakal Birim Fiyatı:" + orangePrice);
            //Console.WriteLine("____ Çilek Birim Fiyatı:" + strawberryPrice);
            //Console.WriteLine("____ Patates Birim Fiyatı:" + potatoPrice);
            //Console.WriteLine("____ Domates Birim Fiyatı:" + tomatoPrice);

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice    = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı : " + shoppingTotalPrice);





            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF..
            //TOPLANTI SAAT 20:00'DE
            //" '

            //char symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //    passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("TC Kimlik No: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("_______________________");
            //Console.WriteLine(" Yolcu TC Kimlik No: "+ " " + passangerIdentityNumber + "Yolcu Ad Soyad: " + passangerName + " " + passangerSurname + " " + passangerDistrict + " / " + passangerCity + " " + passangerAge);

            #endregion


            #region Kalvyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayyakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount  * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar :" + totalPrice);


            #endregion

            #region Kalvyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen birinci sınav notunu giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("lütfen üçüncü sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = ( exam1 +  exam2 + exam3 )/3;

            //Console.WriteLine( "Sınav Ortalaması: " + result );



            #endregion

            #region Klavyeden karakter girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);




            #endregion

            Console.Read();

        }
    }
}
