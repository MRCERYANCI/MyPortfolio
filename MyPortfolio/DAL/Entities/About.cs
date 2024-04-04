using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL.Entities
{
    public class About  //Açıklama Tablosu
    {
        [Key]
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string SubDescription { get; set; }
        public string Details { get; set; }
        public string CV { get; set; }
    }
}
