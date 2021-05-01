using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal
{
    interface IShootModible
    {
        public ShootMode ShootMode { get; set; }

        public abstract void ChangeMode();
    }
}
