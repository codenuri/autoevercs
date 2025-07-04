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
            // 1. 전체 그림 Load 해서 Bitmap 만들기
            // C:\\totoro.jpg 놓으세요
            Uri path = new Uri("C:\\totoro.jpg", UriKind.Absolute);
            BitmapImage bitmap = new BitmapImage(path);

            //---------------------------
            // 2. 블럭 크기 계산
            block_width = bitmap.Width / CNT;
            block_height = bitmap.Height / CNT;

            //---------------------------

            for (int y = 0; y < CNT; y++)
            {
                for (int x = 0; x < CNT; x++)
                {
                    // 3. Bitmap 에서 1번째 블럭만 잘라내기
                    int num = y * CNT + x;

                    // num 번째 블럭이 몇번째 Row, Col 인지 계산
                    int bx = num % CNT; // 2 <== Col
                    int by = num / CNT; // 1 <== Row

                    CroppedBitmap cb = new CroppedBitmap(bitmap,
                                   new Int32Rect((int)(bx * block_width),
                                                 (int)(by * block_height),
                                                 (int)block_width,
                                                 (int)block_height));

                    // 4. 한블럭의 bitmap 으로 Image 객체 만들기
                    Image img = new Image();
                    img.Source = cb;
                    img.Stretch = Stretch.Fill;
                    img.Margin = new Thickness(0.5);


                    Grid.SetRow(img, y);
                    Grid.SetColumn(img, x);

                    grid.Children.Add(img);

                }
            }


          
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
