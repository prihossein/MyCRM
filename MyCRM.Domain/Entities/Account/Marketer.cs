using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCRM.Domain.Entities.Account
{
    public class Marketer
    {
        [Display(Name = "رشته تحصیلی")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string? FeildStudy { get; set; }

        [Display(Name = "سن")]
        [MaxLength(4, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public int? Age { get; set; }

        [Display(Name = "کد ملی")]
        [MaxLength(4, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string IRCode { get; set; }

        [Display(Name = "تحصیلات")]
        public Education Education { get; set; }
    }

    public enum Education
    {
        [Display(Name = "دیپلم")]
        Diploma,
        [Display(Name = "کارشناسی")]
        Bechelor,
        [Display(Name = "کارشناسی ارشد")]
        Master,
        [Display(Name = "دکتری")]
        PHD
    }
}
