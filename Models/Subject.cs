using System.ComponentModel.DataAnnotations;



namespace Group1Pro.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DiscriptiveTitle { get; set; }
        [Required]
        public string ClassSection { get; set; }
        [Required]
        public string Teacher { get; set; }







    }
}
