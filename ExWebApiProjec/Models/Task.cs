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
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'-'MM'-'yyyy}", ApplyFormatInEditMode = true)] //HH:mm:ss
        public DateTime CreationDate { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}