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

        private void PanelOptionConfig(string str1, string str2, bool visible) {
            labelSide1.Content = str1;
            labelSide2.Content = str2;
            side2.Visibility = (visible) ? Visibility.Visible : Visibility.Hidden;

        }

        private bool CheckOption() {
            if (side1.Text == "" || (side2.IsVisible && side2.Text == "")) {
                MessageBox.Show("Error");
                return false;
            } else {
                int num;
                if (!Int32.TryParse(side1.Text, out num) || (side2.IsVisible && !Int32.TryParse(side2.Text, out num))) {
                    return false;
                }
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

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            Point point = Mouse.GetPosition(canvas);
            CheckOption();

            switch (listFigure.SelectedIndex) {
                  case 0: {

                        break;
                } case 1: {

                        break;
                } case 2: {

                        break;
                } case 3: {

                        break;
                } case 4: {

                        break;
                } case 5: {

                        break;
                }

            }
        }
    }
}
