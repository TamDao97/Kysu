using Kysu.DB.DuLich.Model;
using Kysu.DB.DuLich.Model.TouristPlace;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kysu.DB.DuLich.Entities
{
    /// <summary>
    /// Địa điểm du lịch
    /// </summary>
    public partial class TouristPlace
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [Required, MaxLength(500)]
        public string Name { get; set; }
    }

    public partial class TouristPlace
    {
        public static TouristPlace Clone(TouristPlaceModel model)
        {
            return new TouristPlace
            {
                Id = model.Id ?? default,
                ParentId = model.ParentId,
                Name = model.Name
            };
        }
    }
}
