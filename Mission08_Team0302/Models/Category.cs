using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0302.Models
{
    public class Category
    {
        [Key]
        public int category_id { get; set; }
        public string name { get; set; }
    }
}
