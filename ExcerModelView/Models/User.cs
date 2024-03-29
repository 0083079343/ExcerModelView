﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExcerModelView.Models
{
    [Table("T_User")]
    public class User
    {
        [Key]
        [Display(Name = "آیدی")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        public int Id { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [MaxLength(20)]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [MaxLength(30)]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Family { get; set; }
        [Display(Name = "تاریخ تولد")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        public DateTime Birthdate { get; set; }
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [MaxLength(15)]
        [RegularExpression("(09)[0-9]{9}", ErrorMessage = "فرمت شماره موبایل صحیح نیست!")]
        public string Phone { get; set; }
        [Display(Name = "کدملی")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [MaxLength(10)]
        public string Ncode { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        public bool IsActive { get; set; }
        [Display(Name = "تاریخ عضویت")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        public DateTime RegisterDate { get; set; }
        [Display(Name = "عکس کاربر")]
        public string Image { get; set; }

    }
}