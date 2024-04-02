using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get => DateTime.Now; }
    }
}
