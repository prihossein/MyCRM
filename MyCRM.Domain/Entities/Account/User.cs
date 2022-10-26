using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCRM.Domain.Entities.Account
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "{0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string Username { get; set; }

        [Display(Name = "نام")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string? FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string? LastName { get; set; }

        [Display(Name = "ایمیل")]
        [DataType(DataType.EmailAddress,ErrorMessage = "{0} را به صورت صحیح وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string Email { get; set; }

        [Display(Name = "نام تصویر")]
        public string ImageName { get; set; }

        [Display(Name = "شماره موبایل")]
        [RegularExpression(@"^09\d{9}$", ErrorMessage = "{0} صحیح نمی باشد")]
        public string MobilePhone { get; set; }

        [Display(Name = "نام معرف")]
        public string? IdentifierName { get; set; }


        [Display(Name = "جنسیت")]
        public Gender Gender { get; set; }

        [Display(Name = "تاریخ ساخت")]
        public DateTime CreateDate => DateTime.Now;
        public bool IsDelete { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "{0} را وارد کنید")]
        [MaxLength(100,ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public enum Gender
    {
        [Display(Name = "عمومی")]
        General,
        [Display(Name = "مرد")]
        Male,
        [Display(Name = "زن")]
        Female
    }
}
