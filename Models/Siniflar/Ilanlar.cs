using System.ComponentModel.DataAnnotations;

namespace Patililer.Models.Siniflar
{
    public class Ilanlar
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public int Yas { get; set; }
        public string Cinsiyet { get; set; }
        public string Aciklama { get; set; }
        public string IlanImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
        
    }
}
