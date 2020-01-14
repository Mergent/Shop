using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(20)]
        [Required(ErrorMessage = "Имя не может быть более 20ти символов")]
        public string name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(20)]
        [Required(ErrorMessage = "Фамилия не может быть более 20ти символов")]
        public string surname { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(20)]
        [Required(ErrorMessage = "Адрес не может быть более 20ти символов")]
        public string adress { get; set; }

        [Display(Name = "Введите номер телефона")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина номера не более 10ти символов")]
        public string phone { get; set; }

        [Display(Name = "Введите e-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина e-mail более 20ти символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
