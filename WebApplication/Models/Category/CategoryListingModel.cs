using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.Category
{
    public class CategoryListingModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите категория товара ")]
        [Display(Name = "Название категории*")]
        [StringLength(20)]
        public string Name { get; set; }

        [Display(Name ="Описание")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Введите Url категории")]
        [Display(Name ="Url картинки*")]
        public string ImageUrl { get; set; }
    }
}
