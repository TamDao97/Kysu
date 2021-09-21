using System;
using System.Collections.Generic;
using System.Text;

namespace Kysu.DB.DuLich.Model.Base
{
    public class SearchBaseModel
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 15;
    }
}
