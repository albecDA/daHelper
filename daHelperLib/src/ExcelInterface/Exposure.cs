using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration;

namespace daHelper
{
    public partial class RegisterAddIn
    {
        [ExcelFunction]
        public static string dfaHelperConcatArray(object[] s, object delim, object srt_wrap, object end_wrap, object srt, object end)
        {
            string[] _s = ArrayExt.CastArrayString(s);

            string _delim = Marshal<object>.Missing(delim) ? "," : delim.ToString();
            string _srt_wrap = Marshal<object>.Missing(srt_wrap) ? "'" : srt_wrap.ToString();
            string _end_wrap = Marshal<object>.Missing(end_wrap) ? "'" : end_wrap.ToString();
            string _srt = Marshal<object>.Missing(srt) ? "(" : srt.ToString();
            string _end = Marshal<object>.Missing(end) ? ")" : end.ToString();

            return StringManipulation.ConcatArray(_s, _delim, _srt_wrap, _end_wrap, _srt, _end);
        }

        [ExcelFunction]
        public static string dfaHelperConcatMatrix(object[,] s, object delim, object srt_wrap, object end_wrap, object srt, object end, object ByRow, object array_sep)
        {
            string[,] _s = ArrayExt.CastMatrixString(s);

            string _delim = Marshal<object>.Missing(delim) ? "," : delim.ToString();
            string _srt_wrap = Marshal<object>.Missing(srt_wrap) ? "'" : srt_wrap.ToString();
            string _end_wrap = Marshal<object>.Missing(end_wrap) ? "'" : end_wrap.ToString();
            string _srt = Marshal<object>.Missing(srt) ? "(" : srt.ToString();
            string _end = Marshal<object>.Missing(end) ? ")" : end.ToString();
            bool _ByRow = Marshal<object>.Missing(ByRow) ? true : (bool)ByRow;
            string _array_sep = Marshal<object>.Missing(array_sep) ? "," : array_sep.ToString();

            return StringManipulation.ConcatMatrix(_s, _delim, _srt_wrap, _end_wrap, _srt, _end,_ByRow,_array_sep);
        }

        [ExcelFunction]
        public static string dfaHelperTest()
        {
            return "hi";
        }
    }
}
