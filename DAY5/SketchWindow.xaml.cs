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
using System.Windows.Shapes;

namespace SKETCH
{
    /// <summary>
    /// SketchWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SketchWindow : Window
    {
        public SketchWindow()
        {
            InitializeComponent();
        }

        private Point from = new Point(0, 0);

        private void canvas_MouseLeftButtonDown(object sender,  
                                                MouseButtonEventArgs e)
        {
            // 마우스 누를 곳의 좌표를 from 에 기록
            from = e.GetPosition(this);
               
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if ( e.LeftButton == MouseButtonState.Pressed )
            {
                Point to = e.GetPosition(this);

                // WPF 객체지향이 잘되어 있습니다
                Line line = new Line();
                line.Stroke = SystemColors.WindowFrameBrush;

                line.X1 = from.X;
                line.Y1 = from.Y;
                line.X2 = to.X;
                line.Y2 = to.X;

                // canvas layout 에 선을 붙이면 됩니다.
                canvas.Children.Add(line);

            }
        }
    }
}
