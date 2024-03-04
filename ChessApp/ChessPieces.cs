using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChessApp
{
    internal abstract class ChessPiece
    {
        public bool IsWhite
        {
            get { return isWhite; }
            set { isWhite = value; }
        }
        private bool isWhite;

        public ChessPiece()
        {

        }

        public ChessPiece(bool isWhite)
        {
            IsWhite = isWhite;
        }

        public abstract void Move_Start(ChessButton sender, ChessButton[,] buttonArray);
        public abstract void Move_End();
    }

    internal class Pawn : ChessPiece
    {
        public Pawn(bool isWhite) : base(isWhite) 
        {
            IsWhite = isWhite;
        }
        private bool bHasMoved = false;

        public override void Move_Start(ChessButton sender, ChessButton[,] buttonArray)
        {
            sender.Background = new SolidColorBrush(Colors.Red);
            MessageBox.Show(sender.Name);

            Tuple<int, int> buttonCoordinates = ChessButton.CoordinatesOf(sender, buttonArray);

            //Check piece assignment. Does nothing if no piece
            if (sender.piece == null)
                throw new Exception();
            
            if (sender.piece.IsWhite)
            {
                //Move upwards
            }
            else
            {
                //Move downwards
            }
        }

        public override void Move_End()
        {
            return;
        }
    }  
}
