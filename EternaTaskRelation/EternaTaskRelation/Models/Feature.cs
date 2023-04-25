using System.ComponentModel.DataAnnotations;

namespace EternaTaskRelation.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Desc { get; set; }
        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }
    }
}
