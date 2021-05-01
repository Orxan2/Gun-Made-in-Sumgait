using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsenal
{
    interface IZoomable
    {
        public abstract int ZoomLevel { get; set; }

        public abstract void ZoomIn();
        public abstract void ZoomOut();
    }
}
