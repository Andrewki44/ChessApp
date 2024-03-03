using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChessApp
{
    internal class ChessPiece
    {
        private bool isWhite;
        public bool IsWhite
        {
            get { return isWhite; }
            set { isWhite = value; }
        }

        public ChessPiece()
        {

        }

        public ChessPiece(bool isWhite)
        {
            IsWhite = isWhite;
        }
    }

    internal class Pawn : ChessPiece
    {
        private bool bHasMoved = false;
        
        
        public Pawn(bool isWhite) : base(isWhite) 
        {
            IsWhite = isWhite;
        }


    }

    internal class ChessButton : Button
    {
        public ChessPiece piece = new ChessPiece();

        

        
    }
}
