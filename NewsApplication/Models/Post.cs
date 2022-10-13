using System.ComponentModel.DataAnnotations;

namespace NewsApplication.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        public string image { get; set; }

        public DateTime Created { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
