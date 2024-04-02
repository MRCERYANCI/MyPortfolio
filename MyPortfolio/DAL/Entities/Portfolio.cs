using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class Portfolio  //Projeler Tablosu
    {
        [Key]
        public int MyProperty { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageUrl { get; set; }
        public string GithubUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get => DateTime.Now; }
    }
}
