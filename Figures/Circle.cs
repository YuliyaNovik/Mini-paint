using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_paint.Figure {
    class Circle : Ellipse {
        public Circle(int x, int y, int side1) : base(x, y, side1, side1) {}
    }
}
