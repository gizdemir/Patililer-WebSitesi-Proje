using System.ComponentModel.DataAnnotations;

namespace Patililer.Models.Siniflar
{
    public class Adres
    {
        [Key]
        public int ID { get; set; }
        public string AdresAcik { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }     


    }
}
