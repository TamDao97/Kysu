using System;
using System.Collections.Generic;
using System.Text;

namespace Kysu.DB.DuLich.Model.Base
{
    public class SearchResultModel<T>
    {
        public int TotalItem { get; set; }
        public List<T> Data { get; set; }
    }
}
