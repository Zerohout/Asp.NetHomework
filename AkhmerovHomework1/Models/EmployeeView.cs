using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkhmerovHomework1.Models
{
    public class EmployeeView
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        [Display(Name = "Имя")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "В имени должно быть не менее 2х и не более 200 символов")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия является обязательной")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Возраст является обязательным")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Дата рождения является обязательной")]
        [Display(Name = "Дата рождения")]
        public DateTime Birthday { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Дата вступления в должность является обязательной")]
        [Display(Name = "Дата вступления в должность")]
        public DateTime StartWorking { get; set; }
    }
}
