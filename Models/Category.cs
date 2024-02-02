using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookifyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage="Range should be more than 0 and less than 100")]
        public int DisplayOrder { get; set; }
    }
}
