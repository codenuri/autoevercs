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
using System.Windows.Xps.Serialization;

namespace PuzzleGame
{
    /// <summary>
    /// PuzzleWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PuzzleWindow : Window
    {
        private const int CNT = 5;     // 5 * 5. 이 상수만 변경하면 7*7 도 가능
        private const int EMPTY = CNT * CNT - 1;

        // #1. grid Row, Col 초기화
        public void InitGrid()
        {
            for (int i = 0; i < CNT; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        // #3. 게임 그림 출력하기
        private double block_width = 0;
        private double block_height = 0;

        public void DrawGameImage()
        {
            // 전체 그림 Load
            // C:\\totoro.jpg 놓으세요
            Uri path = new Uri("C:\\totoro.jpg", UriKind.Absolute);

            BitmapImage bitmap = new BitmapImage(path);

            Image img = new Image();
            img.Source = bitmap;

            //---------------------------
            // 2. 블럭 크기 계산
            block_width = bitmap.Width / CNT;
            block_height = bitmap.Height / CNT;

            //---------------------------
            // 3. Bitmap 에서 1번째 블럭만 잘라내기
            CroppedBitmap cb = new CroppedBitmap(bitmap,
                           new Int32Rect(0, 0, block_width, block_height));






            Grid.SetRow(img, 0);
            Grid.SetColumn(img, 0);

            grid.Children.Add(img);            
        }

           
        public PuzzleWindow()
        {
            // XAML 의 모든 요소는아래 함수에서 생성/초기화
            InitializeComponent();
                
            // XAML에서 만든 요소를 사용하려면 위 함수 다음에서
            InitGrid();
            DrawGameImage();

        }
    }
}
