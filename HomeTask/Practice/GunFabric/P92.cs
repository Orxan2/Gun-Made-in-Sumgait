using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunFabric
{
    class P92:Gun
    {
        public P92(int totalpistolcount, float pistoltype):base(totalpistolcount,pistoltype)
        {
           
        }

        public override void Reload(int adding)
        {
            while (PistolType != 9.98f)
            {
                Console.Write("Pistol type doesn't match your gun!\n Choose right Pistol Type : ");
                PistolType = float.Parse(Console.ReadLine());
            }
            base.Reload(adding);
        }
    }
}
