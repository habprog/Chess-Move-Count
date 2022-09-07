using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMoveCount.Piece
{
    public class GameModule
    {
        public static object count_paths(Dictionary<int, List<int>> graph, int length)
        {
            var i = new List<int> { 0 };
            var b = new List<int> { 1 };
            List<int> this_row = new ();
            
            foreach (var row in Enumerable.Range(1, length - 1))
            {
                var prev_row = this_row;
                var newRow = new List<int> { 0 };
               //this_row.Add();
                
                foreach (var _tup_1 in graph)
                {
                    this_row = _tup_1.Value;
                    var prev = _tup_1.Value.First();
                    var nexts = _tup_1.Value;
                    foreach (var next_ in nexts)
                    {
                        this_row[next_] += prev_row[prev];
                    }
                }
            }
            return  this_row.Sum();
        }
    }
}
