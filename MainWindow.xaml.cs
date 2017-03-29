using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Mini_paint.Figure;

namespace Mini_paint {
    public partial class MainWindow : Window {
        Painter painter;
        Figure.Figure figure;

        public MainWindow() {
            InitializeComponent();
            this.painter = new Painter(canvas);
            Hexagon hex = new Hexagon(10, 10, 15);
            this.painter.Draw(hex);
        }

        private void CreateCircle() {

        }
        private void CreateEllipse() {

        }
        private void CreateFigure() {

        }
        private void CreateHexagon() {

        }
        private void CreateRectangle() {

        }
        private void CreateTriangle() {

        }

        private void PanelOptionConfig(string str1, string str2, bool visible1, bool visible2) {
            labelSide1.Content = str1;
            labelSide2.Content = str2;
            side1.Visibility = (visible1) ? Visibility.Visible : Visibility.Hidden;
            side2.Visibility = (visible2) ? Visibility.Visible : Visibility.Hidden;

        }

        private void ListFigure_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            switch (listFigure.SelectedIndex) {
                  case 0: {
                        PanelOptionConfig("Radius", "", true, false);
                        break;
                } case 1: {
                        PanelOptionConfig("Side 1", "Side 2", true, true);
                        break;
                } case 2: {
                        PanelOptionConfig("Side", "", true, false);
                        break;
                } case 3: {
                        PanelOptionConfig("Side 1", "Side 2", true, true);
                        break;
                } case 4: {
                        PanelOptionConfig("Side", "", true, false);
                        break;
                } case 5: {
                        PanelOptionConfig("Side", "", true, false);
                        break;
                }

            }
        }
    }
}
