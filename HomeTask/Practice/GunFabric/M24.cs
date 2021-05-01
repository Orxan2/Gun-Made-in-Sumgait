using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunFabric
{
    class M24:Gun,IShootModible,IZoomable
    {
        public ShootMode ShootMode { get; set; }
        public int ZoomLevel { get; set; }


        public M24(int totalpistolcount, float pistoltype) : base(totalpistolcount, pistoltype)

        {

        }

        public void ChangeMode()
        {

            //if (ShootMode == ShootMode.Multi)
            //{
            //    ShootMode = ShootMode.Single;
            //    Console.WriteLine($"Shoot Mode was changed. Current Shoot Mode is ({ShootMode})");
            //}
            //else
            //{               
            //    ShootMode = ShootMode.Multi;
            //    Console.WriteLine($"Shoot Mode was changed. Current Shoot Mode is ({ShootMode})");
            //}

            ShootMode = (ShootMode == ShootMode.Multi) ? ShootMode = ShootMode.Single : ShootMode = ShootMode.Multi;
            Console.WriteLine($"Shoot Mode was changed. Current Shoot Mode is ({ShootMode})");
        }

        public override void Reload(int adding)
        {
            while (PistolType != 69.85f)
            {
                Console.Write("Pistol type doesn't match your gun!\n Choose right Pistol Type : ");
                PistolType = float.Parse(Console.ReadLine());
            }
            base.Reload(adding);
        }
        public override void Shoot()
        {

            if (ShootMode == ShootMode.Single)
            {
                base.Shoot();
                return;
            }
            if (base.CurrentPistolCount <= 1)
            {
                Console.WriteLine("Your gun doesn't have  any bullet.Fill it");
            }

            else
            {
                base.CurrentPistolCount -= 2;
                Console.WriteLine($"Gun was Shouted. Bullet count is ({base.CurrentPistolCount})");
            }
        }

        public void ZoomIn()
        {
            this.ZoomLevel++;
            Console.WriteLine($"Zoom Level was icreased. Current ZoomLevel is ({ZoomLevel})");
        }

        public void ZoomOut()
        {
            if (ZoomLevel <= 0)
            {
                Console.WriteLine("Zoom Level mustn't less than <0");
                return;
            }
            this.ZoomLevel--;
            Console.WriteLine($"Zoom Level was decreased. Current ZoomLevel is ({ZoomLevel})");
        }
    }
}
