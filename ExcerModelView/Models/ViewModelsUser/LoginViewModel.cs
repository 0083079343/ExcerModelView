using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcerModelView.Models.ViewModelsUser
{
    public class LoginViewModel
    {
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [MaxLength(15)]
        [RegularExpression("(09)[0-9]{9}", ErrorMessage = "فرمت شماره موبایل صحیح نیست!")]
        public string Phone { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}