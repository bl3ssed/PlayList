using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace PlayList.Models
{
    public class FAQ
    {
        [Display(Name ="Введите Имя")]
        [Required(ErrorMessage ="Введите верное значение")]
        public string Name { get; set; }

        [Display(Name = "Введите Возраст")]
        [Required(ErrorMessage = "Введите верное значение")]
        public int Age { get; set; }

        [Display(Name = "Введите ваш отзыв")]
        [Required(ErrorMessage = "Введите верное значение")]
        public string Reply { get; set; }
    }
}
