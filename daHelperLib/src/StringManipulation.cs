using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daHelper
{
    public static class StringManipulation
    {
        public static string ConcatArray(string[] s, string delim, string srt_wrap, string end_wrap, string srt, string end)
        {
            StringBuilder res = new StringBuilder();

            res.Append(srt);

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != default)
                {
                    res.Append(srt_wrap);
                    res.Append(s[i]);
                    res.Append(end_wrap);
                }
                
                if (i != s.Length - 1)
                    res.Append(delim);
            }

            res.Append(end);

            return res.ToString();
        }

        public static string ConcatMatrix(string[,] s, string delim, string srt_wrap, string end_wrap, string srt, string end, bool ByRow, string array_sep)
        {
            StringBuilder res = new StringBuilder();
            int row = s.GetUpperBound(0) + 1;
            int col = s.GetUpperBound(1) + 1;

            if (ByRow)
            {
                for (int i = 0; i < row ; i++)
                {
                    res.Append(ConcatArray(ArrayExt.GetRow<string>(s, i), delim, srt_wrap, end_wrap, srt, end));

                    if (i != row - 1)
                    {
                        res.Append(array_sep);
                        res.Append("\n");
                    }
                      
                }
            }
            else
            {
                for (int i = 0; i < col; i++)
                {
                    res.Append(ConcatArray(ArrayExt.GetColumn<string>(s, i), delim, srt_wrap, end_wrap, srt, end));

                    if (i != row - 1)
                    {
                        res.Append(array_sep);
                        res.Append("\n");
                    }
                 
                }

            }

            return res.ToString();
        }
    }
}
