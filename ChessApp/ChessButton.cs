using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ChessApp
{
    internal class ChessButton : Button
    {
        public ChessPiece? piece;

        public static Tuple<int, int> CoordinatesOf(ChessButton button, ChessButton[,] buttonArray)
        {
            int w = buttonArray.GetLength(0); // width
            int h = buttonArray.GetLength(1); // height

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    if (buttonArray[x, y].Equals(button))
                        return Tuple.Create(x, y);
                }
            }

            return Tuple.Create(-1, -1);
        }
    }
}
