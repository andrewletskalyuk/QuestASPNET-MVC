using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _01_QuestAdvanture.Models
{
    public class QuestRoom
    {
        public QuestRoom()
        {
            Images = new List<Images>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }

        [Required]
        [Range(1,100)]
        public int NumberPlayers { get; set; }

        [Required]
        [Range(1,50)]
        public int MinAge { get; set; }

        [StringLength(100)]
        public string Address { get; set; }
        
        [Required]
        [Range(1,99999999)]
        public int Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Company { get; set; }

        [Range(0,5)]
        public int Rate { get; set; }

        [Required]
        [Range(1,10000)]
        public int Price { get; set; }

        [Required]
        [Range(0,5)]
        public int LevelOfFear { get; set; }

        [Required]
        [Range(0,5)]
        public int LevelOfDifficulty { get; set; }
        /*NAV*/
        public virtual ICollection<Images> Images { get; set; }
    }
}