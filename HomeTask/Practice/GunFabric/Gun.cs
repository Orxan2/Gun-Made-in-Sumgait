using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunFabric
{
   abstract class Gun
    {
        public float PistolType { get; protected set; }
        public int CurrentPistolCount { get; protected set; }

        //private int _currentPistolCount;
        //public virtual int CurrentPistolCount
        //{
        //    get
        //    {
        //        return _currentPistolCount;
        //    }
        //    set
        //    {
        //        _currentPistolCount = value;
        //    }
        //}
        public int TotalPistolCount { get; private set; }
        private Random rand = new Random(); 

        public Gun(int totalpistolcount, float pistoltype)
        {
            Console.WriteLine($"right Pistol type of guns which may different in real Life is so : \n " +
                $"p92 : 9.98(mm) \n M416 : 5.56(mm) \n M24 : 69.85(mm) \n Mk14 : 7.62(mm)");
            while(totalpistolcount<1)
            {
                Console.WriteLine("Total Pistol Count mustn't less than <0.Assign again");
                totalpistolcount = Convert.ToInt32(Console.ReadLine());
            }          
            this.TotalPistolCount = totalpistolcount;
            this.PistolType = pistoltype;
            Reload(rand.Next(1,TotalPistolCount));
        }
        public virtual void Reload(int adding)
        {
           
            //if (CurrentPistolCount + adding > TotalPistolCount)
            //{
            //    CurrentPistolCount = TotalPistolCount;
            //}
            //else
            //{
            //    CurrentPistolCount += adding;
            //}

            CurrentPistolCount = (CurrentPistolCount + adding > TotalPistolCount) ? CurrentPistolCount = TotalPistolCount : CurrentPistolCount += adding;
            Console.WriteLine($"Your gun was reloaded. Bullet count is ({CurrentPistolCount})");
        }

        public virtual void Shoot()
        {
           
            if (CurrentPistolCount < 1)
            {
                Console.WriteLine("Your gun doesn't have any bullet.Fill it");
                return;
            }
            CurrentPistolCount--;
            Console.WriteLine($"Gun was Shouted. Current Bullet count is ({CurrentPistolCount})");
        }
    }
}
