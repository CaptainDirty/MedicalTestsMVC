﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalTests.Domain
{
    public class Razrabotchiki
    {
        /// <summary>
        /// ID разработчика
        /// </summary>  
        [Key]
        public int ID_Razrabotchik { get; set; }

        /// <summary>
        /// фамилия разработчика
        /// </summary>  
        [Required(ErrorMessage = "Вы не ввели фамилию врача")]
        [Display(Name = "Фамилия врача")]
        public string Surname { get; set; }

        /// <summary>
        /// имя разработчика
        /// </summary> 
        [Display(Name = "Имя врача")]
        public string Name { get; set; }

        /// <summary>
        /// отчество разработчика
        /// </summary>
        [Display(Name = "Отчество врача")]
        public string Thirdname { get; set; }

        /// <summary>
        /// дата рождения
        /// </summary>    
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateBirth { get; set; }

        public UserProfile Owner { get; set; }
    }
}