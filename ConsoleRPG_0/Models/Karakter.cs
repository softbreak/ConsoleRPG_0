using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_0.Models
{

    internal class Karakter : KarakterYaratikSpec
    {

        //Todo : Silah,zirh ve esya sistemi olusturulacak, bu bonuslar hesaba katılsın

        //Todo : Tecrübe puanına göre level ayarlaması yapılacak(Bunun icin ideal olan bir kontrol metodu yazılması)

        //Todo4: Saldırı sisteminde uzakSaldırı ve büyü yapma sistemi olusturulacak
        //Todo5: Elit yaratıgımız özel kötücül saldırılar edinecek
        //Todo6 : Normal yaratık saldırısı bir düsünülsün...
        //Todo7 : Macera/alısveriş/sehirde dinlenme ve görev alma sistemi olusturulacak


        public Karakter(Sinif sinif, Irk irk)
        {
            Seviye = 1;
            MaksimumCan = MevcutCan = 100;
            MaksimumEnerji = MevcutEnerji = 50;
           
            Sinifi = sinif;
            Irk = irk;

          

            sinif.StatBelirle(this);
            irk.StatBelirle(this);

            Defans = 10 + Dayaniklilik + Seviye;

        }

        #region EncapsulationKodlari
        int _maksimumCan; //İlgili degerimiz Bir Encapsulation'a girecegi zaman field'inizi acıkca yazmalısınız...

        public override int MaksimumCan
        {
            //get ve set metotlarınız Property'nin Ram'deki ilgili degişken veri getirmesi veya o degişkeni veri ataması icin kullanacagınız metotlar
            get
            {
                if (Seviye == 1 && _maksimumCan != 100)
                {
                    throw new Exception("Karakter 1. seviyede olmasına ragmen can puanın bir sıkıntı var");
                }

                return _maksimumCan;
            }
            set
            {
                if (Seviye == 1 && value == 100)
                {
                    _maksimumCan = value;
                }
                else if (Seviye > 1 && value > _maksimumCan)
                {
                    _maksimumCan = value;
                }
                else
                {
                    //Console.WriteLine("Yanlıs bir can puanı atanmaya calısıldıgı icin deger otomatik 100'e cekildi");
                    //_maksimumCan = 100;
                    throw new Exception("Can puanı ile ilgili bir sorun olustu. 1. Seviyedeki bir karakterin can puanını lütfen kurcalamayın");
                }
            }

        } // Property , Karakterin ilgili seviye alabilecegi maksimum can puanıdır...



        int _maksimumEnerji;


        public override int MaksimumEnerji
        {
            get
            {
                if (Seviye == 1 && _maksimumEnerji != 50)
                {
                    throw new Exception("Karakterinizin enerji seviyesinde 1. seviyede olan bir karakter icin bir dengesizlik var");
                }

                return _maksimumEnerji;
            }

            set
            {
                if (Seviye == 1 && value == 50)
                {
                    _maksimumEnerji = value;
                }
                else if (Seviye > 1 && value > _maksimumEnerji)
                {
                    _maksimumEnerji = value;
                }
                else
                {
                    throw new Exception("Karakterinizin enerji seviyesinde bir sorun var lütfen kontrol ediniz");
                }
            }
        }
        #endregion




        #region NormalOzellikler
        public int Seviye { get; set; }

        public Sinif Sinifi { get; set; }
        public Irk Irk { get; set; }


        #endregion




        //Stats
        public int Guc { get; set; }
        public int Ceviklik { get; set; }
        public int Irade { get; set; }
        public int Dayaniklilik { get; set; }

        public int Para { get; set; }

        //Equipment
        public Silah Silahi { get; set; }
        public Zirh Zirhi { get; set; }
        public Tilsim Tilsimi { get; set; }




        public override int YakinSaldiri()
        {

            int saldiri = Sinifi.Isim == "savasci" || Sinifi.Isim == "sovalye" ? rnd.Next(1, 21) : rnd.Next(1, 10);

            if (Silahi != null)
            {
                Silahi.EsyaDayanikliligi--;
              
                return saldiri + Guc + Seviye + Silahi.Hasar;
            }
            
            return saldiri + Guc + Seviye;
        }

        public override void OzelSaldiri()
        {
            throw new NotImplementedException();
        }

        public override int UzakSaldiri()
        {
            int saldiri = Sinifi.Isim == "okcu" || Sinifi.Isim == "ninja" ? rnd.Next(1, 21) : rnd.Next(1, 10);
            if (Silahi != null) return saldiri + Ceviklik + Seviye + Silahi.Hasar;

            return saldiri + Ceviklik + Seviye;
        }


    }
}
