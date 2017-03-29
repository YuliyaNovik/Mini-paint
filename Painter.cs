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
            this.brush = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        public void SetBrush(byte r, byte g, byte b) {
            this.brush = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        public void Draw(Ellipse ellipse) {
            System.Windows.Shapes.Ellipse drawEllipse = new System.Windows.Shapes.Ellipse();
            drawEllipse.Stroke = brush;
            drawEllipse.Width = ellipse.Side1;
            drawEllipse.Height = ellipse.Side2;

            Canvas.SetLeft(drawEllipse, ellipse.X);
            Canvas.SetTop(drawEllipse, ellipse.Y);
            canvas.Children.Add(drawEllipse);
        }

        public void Draw(Hexagon hexagon) {
            foreach (System.Windows.Shapes.Line item in hexagon.LineList) {
                item.Stroke = brush;
                Canvas.SetLeft(item, hexagon.X);
                Canvas.SetTop(item, hexagon.Y);
                canvas.Children.Add(item);
            }
        }

        public void Draw(Rectangle rectangle) {
            System.Windows.Shapes.Rectangle drawRectangle = new System.Windows.Shapes.Rectangle();
            drawRectangle.Width = rectangle.Side1;
            drawRectangle.Height = rectangle.Side2;
            drawRectangle.Stroke = brush;
            Canvas.SetLeft(drawRectangle, rectangle.X);
            Canvas.SetTop(drawRectangle, rectangle.Y);
            canvas.Children.Add(drawRectangle);
        }

        public void Draw(Triangle triangle) {
            foreach (System.Windows.Shapes.Line item in triangle.LineList) {
                item.Stroke = brush;
                Canvas.SetLeft(item, triangle.X);
                Canvas.SetTop(item, triangle.Y);
                canvas.Children.Add(item);
            }
        }
    }
}
