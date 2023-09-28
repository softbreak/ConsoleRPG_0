using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG_0.Models
{
    internal abstract class KarakterYaratikSpec:BaseEntity
    {
        protected Random rnd;

        public KarakterYaratikSpec()
        {
            rnd = new Random();
        }
        public virtual int MaksimumCan { get; set; }
        public int MevcutCan { get; set; }
        public virtual int MaksimumEnerji { get; set; }
        public int MevcutEnerji { get; set; }
        public virtual int TecrubePuani { get; set; }
        public int Defans { get; set; }



        public virtual int YakinSaldiri()
        {
           
            return rnd.Next(1, 21);
        }

        public abstract void OzelSaldiri();

        public virtual int UzakSaldiri()
        {
            Random rnd = new Random();
            return rnd.Next(1, 11);
        }
        

    }
}
