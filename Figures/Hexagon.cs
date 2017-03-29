using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Mini_paint.Figure {
    class Hexagon : Figure{
        private int side1;
        private List<System.Windows.Shapes.Line> lineList = new List<System.Windows.Shapes.Line>();

        public Hexagon(int x, int y, int side1) : base (x, y) {
            this.side1 = side1;
            AddLines();
        }

        public List<System.Windows.Shapes.Line> LineList {
            get { return lineList; }
        }

        private void AddLines(){
            for (int i = 0; i < 6; i++) {
                lineList.Add(new System.Windows.Shapes.Line());
            }

            lineList[0].X1 = side1 / 2;
            lineList[0].Y1 = 0;
            lineList[0].X2 = 3 * side1 / 2;
            lineList[0].Y2 = 0;

            lineList[1].X1 = 3 * side1 / 2;
            lineList[1].Y1 = 0;
            lineList[1].X2 = 2 * side1;
            lineList[1].Y2 = side1 * Math.Sqrt(3) / 2;

            lineList[2].X1 = 2 * side1;
            lineList[2].Y1 = side1 * Math.Sqrt(3) / 2;
            lineList[2].X2 = 3 * side1 / 2;
            lineList[2].Y2 = side1 * Math.Sqrt(3);

            lineList[3].X1 = 3 * side1 / 2;
            lineList[3].Y1 = side1 * Math.Sqrt(3);
            lineList[3].X2 = side1 / 2;
            lineList[3].Y2 = side1 * Math.Sqrt(3);

            lineList[4].X1 = side1 / 2;
            lineList[4].Y1 = side1 * Math.Sqrt(3);
            lineList[4].X2 = 0;
            lineList[4].Y2 = side1 * Math.Sqrt(3) / 2;

            lineList[5].X1 = 0;
            lineList[5].Y1 = side1 * Math.Sqrt(3) / 2;
            lineList[5].X2 = side1 / 2;
            lineList[5].Y2 = 0;
        }
    }
}
