using System;
using System.Collections.Generic;
using System.Text;

namespace Kysu.DB.DuLich.Model.TouristPlace
{
    public class TouristPlaceModel
    {
        public int? Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
    }
}
