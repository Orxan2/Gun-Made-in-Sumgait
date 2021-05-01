using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunFabric
{
    interface IShootModible
    {
        public ShootMode ShootMode { get; set; }

        public void ChangeMode();
    }
}
