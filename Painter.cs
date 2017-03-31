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
        Brush brushFill, brushStroke;

        public Painter(Canvas canvas) {
            this.canvas = canvas;
            this.InitCanvas();
        }

        public void ClearPainter() {
            InitCanvas();
        }

        private void InitCanvas() {
            this.brushFill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            this.Draw(new Rectangle(0, 0, 2000, 2000));
            this.brushFill = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            this.brushStroke = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        public void SetBrushFill(byte r, byte g, byte b) {
            this.brushFill = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        public void SetBrushStroke(byte r, byte g, byte b) {
            this.brushStroke = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        public void ChangeBrushSettings(System.Windows.Shapes.Shape figure) {
            figure.Fill = brushFill;
            figure.Stroke = brushStroke;
        }

        public void Draw(Ellipse ellipse) {
            System.Windows.Shapes.Ellipse drawEllipse = new System.Windows.Shapes.Ellipse();
            ChangeBrushSettings(drawEllipse);
            drawEllipse.Width = ellipse.Side1;
            drawEllipse.Height = ellipse.Side2;

            Canvas.SetLeft(drawEllipse, ellipse.X-ellipse.Side1/2);
            Canvas.SetTop(drawEllipse, ellipse.Y-ellipse.Side2/2);
            canvas.Children.Add(drawEllipse);
        }

        public void Draw(Hexagon hexagon) {
            System.Windows.Shapes.Polygon drawHexagon = new System.Windows.Shapes.Polygon();
            ChangeBrushSettings(drawHexagon);
            PointCollection collection = new PointCollection();
            int centerX = 0, centerY = 0;
            foreach (System.Windows.Shapes.Line item in hexagon.LineList) {
                centerX += (int) item.X1;
                centerY += (int) item.Y1;
                collection.Add(new System.Windows.Point(item.X1, item.Y1));
            }
            drawHexagon.Points = collection;
            Canvas.SetLeft(drawHexagon, hexagon.X-centerX/6);
            Canvas.SetTop(drawHexagon, hexagon.Y-centerY/6);
            canvas.Children.Add(drawHexagon);
        }

        public void Draw(Rectangle rectangle) {
            System.Windows.Shapes.Rectangle drawRectangle = new System.Windows.Shapes.Rectangle();
            drawRectangle.Width = rectangle.Side1;
            drawRectangle.Height = rectangle.Side2;
            ChangeBrushSettings(drawRectangle);
            Canvas.SetLeft(drawRectangle, rectangle.X-rectangle.Side1/2);
            Canvas.SetTop(drawRectangle, rectangle.Y - rectangle.Side2/2);
            canvas.Children.Add(drawRectangle);
        }

        public void Draw(Triangle triangle) {
            System.Windows.Shapes.Polygon drawTriangle = new System.Windows.Shapes.Polygon();
            ChangeBrushSettings(drawTriangle);
            PointCollection collection = new PointCollection();
            int centerX = 0, centerY = 0;
            foreach (System.Windows.Shapes.Line item in triangle.LineList) {
                centerX += (int)item.X1;
                centerY += (int)item.Y1;
                collection.Add(new System.Windows.Point(item.X1, item.Y1));
            }
            drawTriangle.Points = collection;
            Canvas.SetLeft(drawTriangle, triangle.X-centerX/3);
            Canvas.SetTop(drawTriangle, triangle.Y-centerY/3);
            canvas.Children.Add(drawTriangle);
        }
    }
}
