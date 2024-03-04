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

        public abstract List<ChessButton> Move_Piece(ChessButton sender, ChessButton[,] buttonArray);
    }

    internal class Pawn : ChessPiece
    {
        public Pawn(bool isWhite) : base(isWhite) 
        {
            IsWhite = isWhite;
        }
        private bool bHasMoved = false;

        public override List<ChessButton> Move_Piece(ChessButton sender, ChessButton[,] buttonArray)
        {
            Tuple<int, int> buttonCoordinates = sender.CoordinatesOf(buttonArray);
            List<ChessButton> validMoves = new List<ChessButton>();

            //Check Piece assignment. Does nothing if no Piece
            if (sender.Piece == null)
                throw new Exception();
            
            if (sender.Piece.IsWhite)
            {
                //Move upwards
                if (buttonCoordinates.Item1 < 7)

                return validMoves;
            }
            else
            {
                //Move downwards
                return validMoves;
            }
        }
    }

    internal class Rook : ChessPiece
    {
        public Rook(bool isWhite) : base(isWhite)
        {
            IsWhite = isWhite;
        }
        private bool bHasMoved = false;

        public override List<ChessButton> Move_Piece(ChessButton sender, ChessButton[,] buttonArray)
        {
            Tuple<int, int> buttonCoordinates = sender.CoordinatesOf(buttonArray);

            //Check Piece assignment. Does nothing if no Piece
            if (sender.Piece == null)
                throw new Exception();

            if (sender.Piece.IsWhite)
            {
                //Move upwards
                return new List<ChessButton>();
            }
            else
            {
                //Move downwards
                return new List<ChessButton>();
            }
        }
    }

    internal class Knight : ChessPiece
    {
        public Knight(bool isWhite) : base(isWhite)
        {
            IsWhite = isWhite;
        }
        private bool bHasMoved = false;

        public override List<ChessButton> Move_Piece(ChessButton sender, ChessButton[,] buttonArray)
        {
            Tuple<int, int> buttonCoordinates = sender.CoordinatesOf(buttonArray);

            //Check Piece assignment. Does nothing if no Piece
            if (sender.Piece == null)
                throw new Exception();

            if (sender.Piece.IsWhite)
            {
                //Move upwards
                return new List<ChessButton>();
            }
            else
            {
                //Move downwards
                return new List<ChessButton>();
            }
        }
    }

    internal class Bishop : ChessPiece
    {
        public Bishop(bool isWhite) : base(isWhite)
        {
            IsWhite = isWhite;
        }
        private bool bHasMoved = false;

        public override List<ChessButton> Move_Piece(ChessButton sender, ChessButton[,] buttonArray)
        {
            Tuple<int, int> buttonCoordinates = sender.CoordinatesOf(buttonArray);

            //Check Piece assignment. Does nothing if no Piece
            if (sender.Piece == null)
                throw new Exception();

            if (sender.Piece.IsWhite)
            {
                //Move upwards
                return new List<ChessButton>();
            }
            else
            {
                //Move downwards
                return new List<ChessButton>();
            }
        }
    }

    internal class Queen : ChessPiece
    {
        public Queen(bool isWhite) : base(isWhite)
        {
            IsWhite = isWhite;
        }
        private bool bHasMoved = false;

        public override List<ChessButton> Move_Piece(ChessButton sender, ChessButton[,] buttonArray)
        {
            Tuple<int, int> buttonCoordinates = sender.CoordinatesOf(buttonArray);

            //Check Piece assignment. Does nothing if no Piece
            if (sender.Piece == null)
                throw new Exception();

            if (sender.Piece.IsWhite)
            {
                //Move upwards
                return new List<ChessButton>();
            }
            else
            {
                //Move downwards
                return new List<ChessButton>();
            }
        }
    }

    internal class King : ChessPiece
    {
        public King(bool isWhite) : base(isWhite)
        {
            IsWhite = isWhite;
        }
        private bool bHasMoved = false;

        public override List<ChessButton> Move_Piece(ChessButton sender, ChessButton[,] buttonArray)
        {
            Tuple<int, int> buttonCoordinates = sender.CoordinatesOf(buttonArray);

            //Check Piece assignment. Does nothing if no Piece
            if (sender.Piece == null)
                throw new Exception();

            if (sender.Piece.IsWhite)
            {
                //Move upwards
                return new List<ChessButton>();
            }
            else
            {
                //Move downwards
                return new List<ChessButton>();
            }
        }
    }

}
