using System;
using System.Collections.Generic;
using System.Text;

namespace Kysu.Core.Common
{
    public class Constant
    {
        #region:Mã response
        /// <summary>
        /// Thành công
        /// </summary>
        public const int C100 = 100;

        /// <summary>
        /// Lỗi hệ thống
        /// </summary>
        public const int C101 = 101;
        public static Dictionary<int, string> Error = new Dictionary<int, string>
        {
            [100] = "Thành công!",
            [101] = "Lỗi hệ thống!",
        };
        #endregion
    }
}
