using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EshopUkol8_10.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Název Produktu")]
        [Required(ErrorMessage = "Vyplňte název produktu")]
        [StringLength(100, ErrorMessage = "Název produktu je příliš dlouhý")]
        public string Name { get; set; } = "";

        [Display(Name = "Popis Produktu")]
        [Required(ErrorMessage = "Vyplňte popis produktu")]
        [StringLength(100, ErrorMessage = "Popis produktu je příliš dlouhý")]
        public string Description { get; set; } = "";

        [Display(Name = "Cena Produktu")]
        [Required(ErrorMessage = "Vyplňte cenu produktu")]
        [StringLength(100, ErrorMessage = "Cena je příliš dlouhá")]
        public string Count { get; set; } = "";
    }
}
