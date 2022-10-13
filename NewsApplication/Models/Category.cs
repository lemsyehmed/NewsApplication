using System.ComponentModel.DataAnnotations;

namespace NewsApplication.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="اسم التصنيف")]
        public string Name { get; set; }
        [Display(Name = "وصف التصنيف")]
        public string Description { get; set; }
    }
}
