using System;
using System.Collections.Generic;
using System.Text;

namespace Kysu.DB.DuLich.Model.Post
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Sapo { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int TouristPlaceId { get; set; }
    }
}
