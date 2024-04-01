using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.DAL
{
    public class Feature  //Öne Çıkan Tablosu
    {
        [Key]
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
