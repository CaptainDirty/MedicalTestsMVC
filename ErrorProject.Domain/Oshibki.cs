using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalTests.Domain
{
    public class Oshibki
    {
        /// <summary>
        /// ID ошибки
        /// </summary>       
        [Key]
        [Display(Name = "Номер анализа")]
        public int ID_Oshibki { get; set; }

        /// <summary>
        /// ID пользователя
        /// </summary> 
        [Required(ErrorMessage = "Вы не выбрали пользователя")]
        [Display(Name = "Пользователь программного модуля")]
        public int ID_User { get; set; }

        public UserProfile User { get; set; }

        /// <summary>
        /// ID модуля
        /// </summary>
        [Required(ErrorMessage = "Вы не выбрали наименование направления")]
        [Display(Name = "Направление")]
        public int ID_Module { get; set; }

        public Modules Module { get; set; }

        /// <summary>
        /// ID категории
        /// </summary>   
        [Required(ErrorMessage = "Вы не выбрали специальность")]
        [Display(Name = "Специальность")]
        public int ID_Category { get; set; }

        public Categories Category { get; set; }

        /// <summary>
        /// тема
        /// </summary>
        [Required(ErrorMessage = "Вы не ввели тему к анализу")]
        [Display(Name = "Тема анализа")]
        public string Topic { get; set; }

        /// <summary>
        /// дата обнаружения ошибки
        /// </summary>     
        [Required(ErrorMessage = "Вы не заполнили дату для сдачи анализа")]
        [Display(Name = "Дата выполнения анализа")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateDetection { get; set; }

        /// <summary>
        /// комментарий
        /// </summary> 
        [Required(ErrorMessage = "Вы не ввели комментарий к анализу")]
        [Display(Name = "Комментарий к анализу")]
        public string Comment { get; set; }

        /// <summary>
        /// ID разработчика
        /// </summary>      
        [Required(ErrorMessage = "Вы не выбрали врача")]
        [Display(Name = "Врач")]
        public int ID_Razrabotchik { get; set; }

        public Razrabotchiki Razrabotchiki { get; set; }

        /// <summary>
        /// ID статуса
        /// </summary> 
        [Required(ErrorMessage = "Вы не указали статус анализа")]
        [Display(Name = "Статус анализа")]
        public int ID_Status { get; set; }

        public Statuses Status { get; set; }

        /// <summary>
        /// дата начала устранения ошибки
        /// </summary>
        [Display(Name = "Дата начала проведения анализа")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateStart { get; set; }

        /// <summary>
        /// дата окончания устранения ошибки
        /// </summary>        
        [Display(Name = "Дата окончания проведения анализа")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOver { get; set; }
    
    }
}