using ConsoleRPG_0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_0.Models
{
    internal class Sinif : BaseEntity,IStat
    {
        public Sinif(string isim)
        {
            Isim = isim;
        }

        /// <summary>
        /// Bu metot ilgili sınıfa göre karakterinizin tüm yeteneklerinin kactan baslayacagını belirler...
        /// </summary>
        /// <param name="k">Lütfen bir karakter nesnesi giriniz ki karakterinizin statleri belirlensin</param>
        public void StatBelirle(Karakter k)
        {
            switch (Isim.ToLower())
            {
                case "savasci":
                    k.Guc = 3;
                    k.Dayaniklilik = 3;
                    k.Ceviklik = 2;
                    k.Irade = 1;
                    break;
                case "okcu":
                    k.Guc = 2;
                    k.Dayaniklilik = 2;
                    k.Ceviklik = 3;
                    k.Irade = 1;
                    break;
                case "buyucu":
                    k.Guc = 1;
                    k.Dayaniklilik = 1;
                    k.Irade = 3;
                    k.Ceviklik = 2;
                    break;
                case "sovalye":
                    k.Guc = 3;
                    k.Irade = 3;
                    k.Ceviklik = 1;
                    k.Dayaniklilik = 2;
                    break;
                case "ninja":
                    k.Guc = 2;
                    k.Irade = 2;
                    k.Ceviklik = 3;
                    k.Dayaniklilik = 2;
                    break;
            }

        }
        public List<Karakter> Karakterler { get; set; }


    }
}
