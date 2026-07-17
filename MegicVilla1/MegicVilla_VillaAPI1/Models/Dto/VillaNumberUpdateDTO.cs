using System.ComponentModel.DataAnnotations;

namespace MegicVilla_VillaAPI1.Models.Dto
{
    public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }  
    }
}
