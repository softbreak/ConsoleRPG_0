using ConsoleRPG_0.Interfaces;
using ConsoleRPG_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleRPG_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinif savasci = new Sinif("savasci");
            Sinif okcu = new Sinif("okcu");
            Sinif buyucu = new Sinif("buyucu");
            Sinif sovalye = new Sinif("sovalye");
            Sinif ninja = new Sinif("ninja");

            Irk insan = new Irk("insan");
            Irk elf = new Irk("elf");
            Irk ork = new Irk("ork");
            Irk cuce = new Irk("cuce");
            Irk undead = new Irk("undead");

            Console.WriteLine("Lutfen giriş yapmak icin kullanıcı isminizi giriniz");

            string isim = Console.ReadLine();
            Console.WriteLine("Lutfen sifrenizi giriniz");

            string sifre = Console.ReadLine();

            if (isim == "Winterex" && sifre == "123")
            {
                Console.WriteLine("Oyunumuza hosgeldiniz...Karakter yaratmaya hazırsınız...Karakterinizin ismini giriniz");
            }
            else
            {
                Console.WriteLine("Kullanıcı bulunamadı...Oyunumuza giremezsiniz");
                return;
            }

            string karakterIsmi = Console.ReadLine();

            string sinifSecimi;

            Sinif secilenSinif = null;

            do
            {

                Console.WriteLine("Karakterinizin sınıfını seciniz:\n1:Savasci\n2:Okcu\n3:Buyucu\n4:Sovalye\n5:Ninja...Farklı bir secimde ilerleyemezsiniz");
                sinifSecimi = Console.ReadLine();

                switch (sinifSecimi)
                {
                    case "1":
                        secilenSinif = savasci;
                        break;
                    case "2":
                        secilenSinif = okcu;
                        break;
                    case "3":
                        secilenSinif = buyucu;
                        break;
                    case "4":
                        secilenSinif = sovalye;
                        break;
                    case "5":
                        secilenSinif = ninja;
                        break;
                }

            } while (sinifSecimi != "1" && sinifSecimi != "2" && sinifSecimi !="3"&&sinifSecimi != "4" && sinifSecimi != "5");


            Irk secilenIrk = null;
            string irkSecimi;

            do
            {
                Console.WriteLine("Irkınızı seciniz...\n1:İnsan\n2:Ork\n3:Cuce\n4:Elf\n5:Undead..Farklı bir secimde ilerleyemezsiniz");

                irkSecimi = Console.ReadLine();
                switch (irkSecimi)
                {
                    case "1":
                        secilenIrk = insan;
                        break;
                    case "2":
                        secilenIrk = ork;
                        break;
                    case "3":
                        secilenIrk = cuce;
                        break;
                    case "4":
                        secilenIrk = elf;
                        break;
                    case "5":
                        secilenIrk = undead;
                        break;
                }
            } while (irkSecimi != "1" && irkSecimi != "2" && irkSecimi != "3" && irkSecimi != "4" && irkSecimi != "5");

            Karakter k = new Karakter(secilenSinif,secilenIrk);
            k.Isim = isim;

            Console.WriteLine($"Karakterinizin ismi => {k.Isim}...Karakterinizin sınıfı => {k.Sinifi.Isim}...Irkınız => {k.Irk.Isim}...Defansınız... {k.Defans} .. Seviyeniz => {k.Seviye}");

            //Console.ReadLine();


            string oyunModuSecimi;

            do
            {
                Console.WriteLine("Ne yapmak istiyorsunuz? 1. Macera\n2. Dinlemek\n3:Alısveriş\n4:Gorev\n5:Cikis...Varolan bir secim yapmadan bu sorudan kurtulamazsınız");
                oyunModuSecimi = Console.ReadLine();
                if(oyunModuSecimi == "1")
                {
                    Yaratik y = new Yaratik();
                    y.Defans = k.Seviye * 10;
                    y.MevcutCan = y.MaksimumCan = k.Seviye * 50;
                    Console.WriteLine($"Karsınıza cıkan yaratıgın canı => {y.MaksimumCan},Defansı => {y.Defans}..Saldırı baslıyor..Lütfen secim yapın..\n1.Yakın Saldırı\n2.Uzak Saldırı...Secim dısında varsayılan yakın saldırı yapılacaktır");
                    bool dovusDevam = true;
                    do
                    {
                      

                      

                        string saldiriSacimi = Console.ReadLine();
                        switch (saldiriSacimi)
                        {
                            case "1":
                            default:
                                int yakinSaldiri = k.YakinSaldiri() - y.Defans;
                                if (yakinSaldiri <= 0) yakinSaldiri = 0;
                                y.MevcutCan -= yakinSaldiri;
                                int yaratikSaldirisi = y.YakinSaldiri() - k.Defans;
                                if (yaratikSaldirisi <= 0) yaratikSaldirisi = 0;
                                k.MevcutCan -= yaratikSaldirisi;
                                
                                break;
                            case "2":
                                int uzakSaldiri = k.UzakSaldiri() - y.Defans;
                                if (uzakSaldiri <= 0) uzakSaldiri = 0;
                                y.MevcutCan -= uzakSaldiri;
                                int yaratikUzakSaldirisi = y.UzakSaldiri() - k.Defans;
                                if (yaratikUzakSaldirisi <= 0) yaratikUzakSaldirisi = 0;
                                k.MevcutCan -= yaratikUzakSaldirisi;
                                break;
                        }

                        if(y.MevcutCan <= 0)
                        {
                            Console.WriteLine("Tebrikler yaratıgı öldürüp bu macerayı sonlandırdınız...");
                            Random rnd = new Random();
                            int odul =  rnd.Next(300, 1000);
                            if (rnd.Next(1, 101) <= 30)
                            {
                                Silah s = new Silah();
                                s.Bonus = 2;
                                s.BonusOzellikler.Add(Enums.BonusOzellik.Guc);
                                s.BonusOzellikler.Add(Enums.BonusOzellik.Dayaniklilik);
                                s.Hasar = 5;
                                k.Silahi = s;
                                s.StatBelirle(k);
                            }

                            k.Para += odul;
                            dovusDevam = false;
                            continue;
                        }

                        Console.WriteLine($"Saldırı yapıldı...Yaratıgın kalan canı => {y.MevcutCan}..Sizin canınız {k.MevcutCan}...Devam etmek istiyor musunuz?\n1:Devam,2:Cıkıs,Varsayılan devam...");

                        string macera = Console.ReadLine();
                        switch (macera)
                        {
                            case "2":
                                dovusDevam = false;
                                break;

                        }

                    } while (dovusDevam);
                }

                else if(oyunModuSecimi == "5")
                {
                    Console.WriteLine("Maceradan cıkılıyor...");
                    break;
                }

            } while (oyunModuSecimi!="1" && oyunModuSecimi!="2" && oyunModuSecimi!="3" && oyunModuSecimi!="4" && oyunModuSecimi!="5");





        }
    }
}
