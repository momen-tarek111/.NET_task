using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public bool available { get; set; }
        public int CategoryId {  get; set; }
        [ForeignKey("CategoryId")]
        public Category category { get; set; }
    }
}
