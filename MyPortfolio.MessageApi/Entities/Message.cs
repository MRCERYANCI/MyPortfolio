﻿using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.MessageApi.Entities
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public string IPAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsRead { get; set; }
    }
}
