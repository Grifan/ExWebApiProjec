using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ExWebApiProjec.Models
{
    public class Task
    {
        //[ScaffoldColumn(false)]
        public int Id { get; set; }
        [Display(Name = "Название")]
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [ScaffoldColumn(false)]
        [Display(Name = "Дата создания")]
        [DisplayFormat(DataFormatString = "{0:dd'-'MM'-'yyyy}", ApplyFormatInEditMode = true)] //HH:mm:ss
        public DateTime CreationDate { get; set; }

        [Display(Name = "Дата начала")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd'-'MM'-'yyyy HH:mm:ss}", ApplyFormatInEditMode = true)] //HH:mm:ss
         public DateTime Start { get; set; }

        [Display(Name = "Дата завершения")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'-'MM'-'yyyy HH:mm}", ApplyFormatInEditMode = true)] //HH:mm:ss
        public DateTime Finish { get; set; }
    }
}