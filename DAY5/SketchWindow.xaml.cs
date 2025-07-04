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

        }
    }
}
