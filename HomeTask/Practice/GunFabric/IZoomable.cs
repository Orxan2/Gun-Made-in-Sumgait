using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunFabric
{
    interface IZoomable
    {
        public int ZoomLevel { get; set; }


        public void ZoomIn();
        public void ZoomOut();
    }
}
