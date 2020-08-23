using System.ComponentModel.DataAnnotations;

namespace Server
{
    public class DocDto
    {
        public int Id { get; set; }

        [Required]
        [IsValidPath]
        public string Url { get; set; }
        
        [Required]
        public string Title { get; set; }

        public string Content { get; set; }
    }
}