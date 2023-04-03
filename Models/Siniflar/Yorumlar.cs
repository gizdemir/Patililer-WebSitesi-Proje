using System.ComponentModel.DataAnnotations;

namespace Patililer.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public Ilanlar Ilanlar { get; set; }
    }
}
