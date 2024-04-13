﻿namespace MyPortfolio.Dtos.MessageDtos
{
    public class CreateMessageDto
    {
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
