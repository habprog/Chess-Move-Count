using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMoveCount.Contract
{
    public interface ChessPiece
    {
        /**
	     * List of numbers where the piece can move
         * @param position -  the possible positions from
         * @return list of numbers the piece
	     */
        public List<int> getPossibleDestinations(int position);

        /**
         * The move to a given number
         * @param numberTo - number key
         */
        public void registerMoveTo(int numberTo) { }
    }
}
