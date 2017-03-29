using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Mini_paint.Figure {
    class Ellipse : Figure {
        private double side1;
        private double side2;

        public Ellipse(int x, int y, double side1, double side2) : base(x, y) {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double Side1 {
            get { return side1; }
        }
        public double Side2 {
            get { return side2; }
        }
    }
}
