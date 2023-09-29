using System.ComponentModel;

namespace Entity_DBAccess.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set;}
        public MovieCategory Category { get; set; }
    }

    public enum MovieCategory
    {
        Series = 0,
        Films = 1,
        Documentary = 2,
    }
}
