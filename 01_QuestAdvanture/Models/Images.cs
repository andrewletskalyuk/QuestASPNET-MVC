using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _01_QuestAdvanture.Models
{
    public class Images
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Path { get; set; }
        
        /*Navigation properties*/
        public virtual QuestRoom QuestRoom { get; set; }
    }
}