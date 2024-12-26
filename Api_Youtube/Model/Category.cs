using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api_Youtube.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Video> Videos { get; set; }
    }
}