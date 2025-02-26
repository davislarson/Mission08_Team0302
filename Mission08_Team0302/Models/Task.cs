using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0302.Models
{
    public class Task
    {
        [Key]
        public string task_id { get; set; }
        [Required]
        public string task_description { get; set; }
        public string due_date { get; set; }
        [Range(1, 4)]
        [Required]
        public int quadrant { get; set; }
        [Required]
        public int category_id { get; set; }
        public Category Category { get; set; }
        public bool completed { get; set; }

    }
}
