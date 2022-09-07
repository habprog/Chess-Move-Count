using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMoveCount
{
    public class GameMove
    {
        public List<String> result = new();
        public List<String> getAllMoves()
        {
            helper(1, 0, "3");
            return result;
        }
        public void helper(int prevI, int prevJ, String prev)
        {

            for (int i = 0; i < 3; ++i)
            {
                if (i != prevI)
                {
                    String newResult = prev;
                    newResult = newResult + (i * 3 + prevJ + 1);

                    if (newResult.Length == 7)
                    {
                        result.Add(newResult);
                    }
                    else
                    {
                        helper(i, prevJ, newResult);
                    }
                }
            }

            for (int j = 0; j < 3; ++j)
            {
                if (j != prevJ)
                {
                    String newResult = prev;
                    newResult = newResult + (prevI * 3 + j + 1);

                    if (newResult.Length == 7)
                    {
                        result.Add(newResult);
                    }
                    else
                    {
                        helper(prevI, j, newResult);
                    }
                }
            }
        }
    }
}
