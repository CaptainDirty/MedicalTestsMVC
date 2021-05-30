using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalTests.Domain
{
    public class Categories
    {
        /// <summary>
        /// ID категории
        /// </summary>
        [Key]
        public int ID_Category { get; set; }

        /// <summary>
        /// Наименование пользователя
        /// </summary>
        [Required(ErrorMessage = "Вы не ввели наименование специальности")]        
        [Display(Name = "Наименование специальности")]
        public string NameCategory { get; set; }

        public UserProfile Owner { get; set; }
    }
}