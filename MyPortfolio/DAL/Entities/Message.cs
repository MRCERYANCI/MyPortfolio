using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public DateTime CreatedDate { get => DateTime.Now; }
        public bool IsRead { get => false; }
    }
}
