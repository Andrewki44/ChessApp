using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Database;

namespace ChessApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Database.Database.createDbFile();
        }

        private void MenuItem_New_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
            
        }

        /// <summary>
        /// Resets board to default state
        /// </summary>
        private void NewGame()
        {
            BitmapImage PawnWhite = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\PawnWhite.png"));
            BitmapImage RookWhite = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\RookWhite.png"));
            BitmapImage KnightWhite = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\KnightWhite.png"));
            BitmapImage BishopWhite = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\BishopWhite.png"));
            BitmapImage QueenWhite = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\QueenWhite.png"));
            BitmapImage KingWhite = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\KingWhite.png"));

            BitmapImage PawnBlack = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\PawnBlack.png"));
            BitmapImage RookBlack = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\RookBlack.png"));
            BitmapImage KnightBlack = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\KnightBlack.png"));
            BitmapImage BishopBlack = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\BishopBlack.png"));
            BitmapImage QueenBlack = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\QueenBlack.png"));
            BitmapImage KingBlack = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\ChessPieces\\KingBlack.png"));


            B1.Content = new Image
            {
                Source = PawnWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            B2.Content = new Image
            {
                Source = PawnWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            B3.Content = new Image
            {
                Source = PawnWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            B4.Content = new Image
            {
                Source = PawnWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            B5.Content = new Image
            {
                Source = PawnWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            B6.Content = new Image
            {
                Source = PawnWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            B7.Content = new Image
            {
                Source = PawnWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            B8.Content = new Image
            {
                Source = PawnWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };

            A1.Content = new Image
            {
                Source = RookWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            A8.Content = new Image
            {
                Source = RookWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };

            A2.Content = new Image
            {
                Source = KnightWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            A7.Content = new Image
            {
                Source = KnightWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };

            A3.Content = new Image
            {
                Source = BishopWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            A6.Content = new Image
            {
                Source = BishopWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };

            A4.Content = new Image
            {
                Source = QueenWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };

            A5.Content = new Image
            {
                Source = KingWhite,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };

            G1.Content = new Image
            {
                Source = PawnBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            G2.Content = new Image
            {
                Source = PawnBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            G3.Content = new Image
            {
                Source = PawnBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            G4.Content = new Image
            {
                Source = PawnBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            G5.Content = new Image
            {
                Source = PawnBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            G6.Content = new Image
            {
                Source = PawnBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            G7.Content = new Image
            {
                Source = PawnBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            G8.Content = new Image
            {
                Source = PawnBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };

            H1.Content = new Image
            {
                Source = RookBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            H8.Content = new Image
            {
                Source = RookBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };

            H2.Content = new Image
            {
                Source = KnightBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            H7.Content = new Image
            {
                Source = KnightBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };

            H3.Content = new Image
            {
                Source = BishopBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
            H6.Content = new Image
            {
                Source = BishopBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };

            H4.Content = new Image
            {
                Source = KingBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };

            H5.Content = new Image
            {
                Source = QueenBlack,
                VerticalAlignment = VerticalAlignment.Center,
                Stretch = Stretch.Fill
            };
        }

        private void Chessboard_Loaded(object sender, RoutedEventArgs e)
        {
            NewGame();
        }
    }
}