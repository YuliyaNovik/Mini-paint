using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Mini_paint {
    public partial class MainWindow : Window {
        Painter painter;
        bool ClickBtn = false;

        public MainWindow() {
            InitializeComponent();
            this.painter = new Painter(canvas);
        }

        private void CreateCircle(int x, int y, int side) {
            painter.Draw(new Figure.Circle(x, y, side));
        }
        private void CreateEllipse(int x, int y, int side1, int side2) {
            painter.Draw(new Figure.Ellipse(x, y, side1, side2));
        }
        private void CreateHexagon(int x, int y, int side) {
            painter.Draw(new Figure.Hexagon(x, y, side));
        }
        private void CreateRectangle(int x, int y, int side1, int side2) {
            painter.Draw(new Figure.Rectangle(x, y, side1, side2));
        }
        private void CreateSquare(int x, int y, int side) {
            painter.Draw(new Figure.Square(x, y, side));
        }
        private void CreateTriangle(int x, int y, int side) {
            painter.Draw(new Figure.Triangle(x, y, side));
        }

        private void PanelOptionConfig(string str1, string str2, bool visible) {
            labelSide1.Content = str1;
            labelSide2.Content = str2;
            side2.Visibility = (visible) ? Visibility.Visible : Visibility.Hidden;
        }

        private bool CheckOption() {
            if (side1.Text == "" || (side2.IsVisible && side2.Text == "")) {
                return false;
            }
            return true;
        }

        private void ListFigure_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            switch (listFigure.SelectedIndex) {
                  case 0: {
                        PanelOptionConfig("Radius", "", false);
                        break;
                } case 1: {
                        PanelOptionConfig("Side 1", "Side 2", true);
                        break;
                } case 2: {
                        PanelOptionConfig("Side", "", false);
                        break;
                } case 3: {
                        PanelOptionConfig("Side 1", "Side 2", true);
                        break;
                } case 4: {
                        PanelOptionConfig("Side", "", false);
                        break;
                } case 5: {
                        PanelOptionConfig("Side", "", false);
                        break;
                }

            }
        }

        private void CreateDrawObject(Point point) {
            if (point.X > 370) {
                return;
            }

            int sideLen1, sideLen2;
            if (!Int32.TryParse(side1.Text, out sideLen1)) {
                return;
            }
            if (!Int32.TryParse(side2.Text, out sideLen2) && side2.IsVisible) {
                return;
            }

            switch (listFigure.SelectedIndex) {
                  case 0: {
                        CreateCircle((int) point.X, (int) point.Y, sideLen1);
                        break;
                } case 1: {
                        CreateEllipse((int)point.X, (int)point.Y, sideLen1, sideLen2);
                        break;
                } case 2: {
                        CreateHexagon((int)point.X, (int)point.Y, sideLen1);
                        break;
                } case 3: {
                        CreateRectangle((int)point.X, (int)point.Y, sideLen1, sideLen2);
                        break;
                } case 4: {
                        CreateSquare((int)point.X, (int)point.Y, sideLen1);
                        break;
                } case 5: {
                        CreateTriangle((int)point.X, (int)point.Y, sideLen1);
                        break;
                }

            }
        }

        private void CheckMouseOver(Point point) {
            if (point.X >= 370 || point.X <= 3 || point.Y >= 450 || point.Y <= 10) {
                ClickBtn = false;
            }
        }

        private void DrawOnCanvas() {
            Point point = Mouse.GetPosition(canvas);
            CheckMouseOver(point);
            CheckOption();
            CreateDrawObject(point);
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            ClickBtn = true;
            DrawOnCanvas();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e) {
            if (ClickBtn) DrawOnCanvas();
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e) {
            ClickBtn = false;
        }

        private void ListColor_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            switch (listColor.SelectedIndex) {
                  case 0: {
                        painter.SetBrush(255, 255, 255);
                        break;
                } case 1: {
                        painter.SetBrush(0, 0, 0);
                        break;
                } case 2: {
                        painter.SetBrush(255, 0, 0);
                        break;
                } case 3: {
                        painter.SetBrush(0, 255, 0);
                        break;
                } case 4: {
                        painter.SetBrush(0, 0, 255);
                        break;
                }
            }
        }
    }
}
