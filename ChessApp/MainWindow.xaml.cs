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
        Database.Database sqlite = new Database.Database();
        ChessButton[,] buttonArray = new ChessButton[8, 8];
        bool isPieceSelected = false;
        
        public MainWindow()
        {
            InitializeComponent();

            sqlite.createDbFile();

            ChessButton[,] buttons = {
                { A1, A2, A3, A4, A5, A6, A7, A8 },
                { B1, B2, B3, B4, B5, B6, B7, B8 },
                { C1, C2, C3, C4, C5, C6, C7, C8 },
                { D1, D2, D3, D4, D5, D6, D7, D8 },
                { E1, E2, E3, E4, E5, E6, E7, E8 },
                { F1, F2, F3, F4, F5, F6, F7, F8 },
                { G1, G2, G3, G4, G5, G6, G7, G8 },
                { H1, H2, H3, H4, H5, H6, H7, H8 },
            };
            buttonArray = buttons;
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

            for (int i = 0; i < 8; i++)
            {
                buttonArray[1,i].Content = new Image
                {
                    Source = PawnWhite,
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                buttonArray[1,i].piece = new Pawn(true);
            }            

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

            for (int i = 0; i < 8; i++)
            {
                buttonArray[6, i].Content = new Image
                {
                    Source = PawnBlack,
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
            }

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

        private void ChessButton_Click(object sender, RoutedEventArgs e)
        {
            ChessButton? button = sender as ChessButton;
            if (button == null)
                return;

            if (button.piece != null)
            {
                if (!isPieceSelected)
                {
                    try
                    {
                        button.piece.Move_Start(button, buttonArray);
                        isPieceSelected = true;
                    }
                    catch
                    {
                        return;
                    }
                }
                else
                {
                    try
                    {
                        button.piece.Move_End();
                        isPieceSelected = false;
                    }
                    catch
                    {
                        return;
                    }
                }
            }
            else
            {
                return;
            }
        }
    }
}