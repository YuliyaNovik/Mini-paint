using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Windows.Controls;
using System.Text;
using System.Threading.Tasks;
using Mini_paint.Figure;

namespace Mini_paint {
    class Painter {
        Canvas canvas;
        Brush brush;

        public Painter(Canvas canvas) {
            this.canvas = canvas;
            this.InitCanvas();
        }

        private void InitCanvas() {
            this.brush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            this.Draw(new Rectangle(0, 0, 1000, 1000));
            this.brush = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        public void SetBrush(byte r, byte g, byte b) {
            this.brush = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        public void Draw(Ellipse ellipse) {
            System.Windows.Shapes.Ellipse drawEllipse = new System.Windows.Shapes.Ellipse();
            drawEllipse.Fill = brush;
            drawEllipse.Width = ellipse.Side1;
            drawEllipse.Height = ellipse.Side2;

            Canvas.SetLeft(drawEllipse, ellipse.X);
            Canvas.SetTop(drawEllipse, ellipse.Y);
            canvas.Children.Add(drawEllipse);
        }

        public void Draw(Hexagon hexagon) {
            System.Windows.Shapes.Polygon drawHexagon = new System.Windows.Shapes.Polygon();
            drawHexagon.Fill = brush;
            PointCollection collection = new PointCollection();
            foreach (System.Windows.Shapes.Line item in hexagon.LineList) {
                collection.Add(new System.Windows.Point(item.X1, item.Y1));
            }
            drawHexagon.Points = collection;
            Canvas.SetLeft(drawHexagon, hexagon.X);
            Canvas.SetTop(drawHexagon, hexagon.Y);
            canvas.Children.Add(drawHexagon);
        }

        public void Draw(Rectangle rectangle) {
            System.Windows.Shapes.Rectangle drawRectangle = new System.Windows.Shapes.Rectangle();
            drawRectangle.Width = rectangle.Side1;
            drawRectangle.Height = rectangle.Side2;
            drawRectangle.Fill = brush;
            Canvas.SetLeft(drawRectangle, rectangle.X);
            Canvas.SetTop(drawRectangle, rectangle.Y);
            canvas.Children.Add(drawRectangle);
        }

        public void Draw(Triangle triangle) {
            System.Windows.Shapes.Polygon drawTriangle = new System.Windows.Shapes.Polygon();
            drawTriangle.Fill = brush;
            PointCollection collection = new PointCollection();
            foreach (System.Windows.Shapes.Line item in triangle.LineList) {
                collection.Add(new System.Windows.Point(item.X1, item.Y1));
            }
            drawTriangle.Points = collection;
            Canvas.SetLeft(drawTriangle, triangle.X);
            Canvas.SetTop(drawTriangle, triangle.Y);
            canvas.Children.Add(drawTriangle);
        }
    }
}
