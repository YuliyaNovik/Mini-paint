using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Mini_paint.Figure {
    class Triangle : Figure {
        private int side1;
        private List<Line> lineList = new List<Line>();

        public Triangle(int x, int y, int side1) : base(x, y) { 
            this.side1 = side1;
            AddLines();
        }

        public List<Line> LineList {
            get { return lineList; }
        }

        private void AddLines() {
            for (int i = 0; i < 3; i++) {
                lineList.Add(new Line());
            }

            lineList[0].X1 = side1 / 2;
            lineList[0].Y1 = 0;
            lineList[0].X2 = side1;
            lineList[0].Y2 = side1 * Math.Sqrt(3) / 2;

            lineList[1].X1 = side1;
            lineList[1].Y1 = side1 * Math.Sqrt(3) / 2;
            lineList[1].X2 = 0;
            lineList[1].Y2 = side1 * Math.Sqrt(3) / 2;

            lineList[2].X1 = 0;
            lineList[2].Y1 = side1 * Math.Sqrt(3) / 2;
            lineList[2].X2 = side1 / 2;
            lineList[2].Y2 = 0;

        }
    }
}
