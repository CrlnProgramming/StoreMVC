using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Product
{
    public class NewProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите название продукта")]
        [Display(Name = "Навзавние продукта*")]
        [StringLength(35)]
        public string Name { get; set; }

        /*[Required(ErrorMessage = "Введите название продукта")]
        [Display(Name = "Навзавние продукта*")]
        [StringLength(35)]
        public string Name { get; set; }*/
    }
}
