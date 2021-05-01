using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal
{
   abstract class Gun
    {
        public float PistolType { get; set; }
        public int CurrentPistolCount { get; set; }
        public int TotalPistolCount { get; set; }

        public virtual void Shoot()
        {
            Console.WriteLine("Shooting");
        }
        public virtual void Reload()
        {
            Console.WriteLine("Reloading");
        }
    }
}
