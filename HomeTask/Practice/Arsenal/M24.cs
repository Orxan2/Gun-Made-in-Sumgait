using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal
{
    class M24 : Gun, IShootModible, IZoomable
    {
        public ShootMode ShootMode { get; set; }
        public int ZoomLevel { get; set; }
 
        public void ChangeMode()
        {
            Console.WriteLine("Changed Mode");
        }

       public void ZoomIn()
        {
            Console.WriteLine("Zoom In");
        }

       public void ZoomOut()
        {
            Console.WriteLine("Zoom Out");
        }
    }

}
