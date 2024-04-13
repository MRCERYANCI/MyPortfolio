namespace MyPortfolio.MessageApi.Dtos.ContactDtos
{
    public class GetByIdContactDto
    {
        public int ContactId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
