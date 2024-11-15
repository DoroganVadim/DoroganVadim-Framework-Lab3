using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3.Models
{
    public class Task
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        
        [ForeignKey("idCategory")]
        public virtual Category? category { get; set; }

        public virtual ICollection<Tag> tags { get; set; }
    }
}
