using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class NewProductModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите имя продукта")]
        [Display(Name = "Продукт*")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Введите url продукта")]
        [Display(Name ="Url*")]
        public string ImageUrl { get; set; }

        [Display(Name = "Короткое описание")]
        public string ShortDescrtipiton { get; set; }

        [Display(Name = "Полное описание")]
        public string LongDescription { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите цену для продукта")]
        [Range(0.1,double.MaxValue)]
        [Display(Name ="Цена*")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Введите предпочительный продукт")]
        [Display(Name = "Предпочительный продукт?*")]
        public bool? IsPreferedProduct { get; set; } = false;

        [Range(0, double.MaxValue)]
        [Required(ErrorMessage ="Введите сколько имеется товара на складе")]
        [Display(Name = "In stock*")]
        public int? InStock { get; set; }
        [Required(ErrorMessage ="Пожалуйста выберете категорию")]
        [Range(1,double.MaxValue)]
        public int? CategoryId { get; set; }
    }
}
