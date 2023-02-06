using System.ComponentModel.DataAnnotations;

namespace MovieTicketApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public int ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public List<Actor_Movie> Movies { get; set; }
    }
}
