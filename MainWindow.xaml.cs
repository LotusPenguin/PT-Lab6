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
using System.Windows.Forms;

namespace PT_Lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Drawing.Color activeColor;

        public MainWindow()
        {
            InitializeComponent();
            Brush brush = Brushes.Red;
            Line line = new Line()
            {
                X1 = 10,
                Y1 = 10,
                X2 = 100,
                Y2 = 100,
                Stroke = brush,
                StrokeThickness = 5
            };

            canvas.Children.Add(line);
        }

        private void colorChoiceButton_Click(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                activeColor = colorDialog.Color;

                Brush brush = new SolidColorBrush(Color.FromRgb(
                   colorDialog.Color.R,
                   colorDialog.Color.G,
                   colorDialog.Color.B));
                colorChoiceButton.Background = brush;
            }
        }

        private void canvas_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Point point = e.GetPosition(this);


        }

    }
}
