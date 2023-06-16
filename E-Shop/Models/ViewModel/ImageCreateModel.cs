using System.ComponentModel.DataAnnotations;

namespace E_Shop.Models.ViewModel
{
    public class ImageCreateModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please Choose imagefile")]
        [Display(Name= "Choose Image")]
        public IFormFile ImagePath { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal price { get; set; }
        [Required]
        public string ProductColor { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
