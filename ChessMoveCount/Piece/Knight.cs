using ChessMoveCount.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMoveCount.Piece
{
    public class Knight : ChessPiece
    {
        // Map with the destination based on the position
        public Dictionary<int, List<int>> destinationsForKey;
		public Knight()
		{
			destinationsForKey = new Dictionary<int, List<int>>();

			destinationsForKey.Add(0, new List<int>{ 0, 4, 6});
			destinationsForKey.Add(1, new List<int> { 1, 6, 8 });
			destinationsForKey.Add(2, new List<int> { 2, 7, 9 });
			destinationsForKey.Add(3, new List<int> { 3, 4, 8 });
			destinationsForKey.Add(4, new List<int> { 4, 0, 3, 9 });
			destinationsForKey.Add(5, new List<int> { 5 });
			destinationsForKey.Add(6, new List<int> { 0, 1, 6, 7 });
			destinationsForKey.Add(7, new List<int> { 7, 6, 2 });
			destinationsForKey.Add(8, new List<int> { 8, 1, 3 });
			destinationsForKey.Add(9, new List<int> { 9, 4, 2 });
		}

        public List<int> getPossibleDestinations(int position)
        {
			return destinationsForKey[position];
		}
    }
}
