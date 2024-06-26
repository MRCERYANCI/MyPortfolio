﻿namespace MyPortfolio.MessageApi.Dtos.ContactDtos
{
    public class CreateContactDto
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
