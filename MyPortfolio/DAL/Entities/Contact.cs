using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get => DateTime.Now; }
    }
}
