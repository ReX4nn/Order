using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class OrderViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Город отправителя")]
        [Required(ErrorMessage = "Введите город отправителя")]
        public string SenderCity { get; set; }

        [Display(Name = "Адрес отправителя")]
        [Required(ErrorMessage = "Введите Адрес отправителя")]
        public string SenderAddress { get; set; }

        [Display(Name = "Город получателя")]
        [Required(ErrorMessage = "Введите город получателя")]
        public string RecepientCity { get; set; }

        [Display(Name = "Адрес получателя")]
        [Required(ErrorMessage = "Введите адрес получателя")]
        public string RecepientAddress { get; set; }

        [Display(Name = "Вес груза")]
        [Required(ErrorMessage = "Введите вес груза")]
        public double Wheight { get; set; }

        [Display(Name = "Дата забора груза")]
        [Required(ErrorMessage = "Введите дату забора груза")]
        [BindProperty, DataType(DataType.Date)]
        public DateTime PickupDate { get; set; }
    }
}
