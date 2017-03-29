using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Mini_paint.Figure {
    abstract class Figure {
        private int x;
        private int y;

        public Figure(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public int X {
            get { return x; }
        }

        public int Y {
            get { return y; }
        }
    }
}
