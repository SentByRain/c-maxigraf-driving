using System;
using System.Collections.Generic;
using System.Text;

namespace Flood_Fill__test_
{
    class Rows
    {
        public static void UpRow(float anc1, float anc2, float anc3, float anc4, int anc5, int anc6)
        {
            while (anc1 <= 55-2*anc4)
            {
                FloodFill.LinesAtDiffAngl(anc1, anc2, anc3, anc4, anc5, anc6);
                anc1 += 2 * anc4;
            }
        }
        public static void DownRow(float anc1, float anc2, float anc3, float anc4, int anc5, int anc6)
        {
            while (anc1 >= -55+anc4)
            {
                FloodFill.LinesAtDiffAngl(anc1, anc2, anc3, anc4, anc5, anc6);
                anc1 -= 2 * anc4;
            }
        }
    }
}
