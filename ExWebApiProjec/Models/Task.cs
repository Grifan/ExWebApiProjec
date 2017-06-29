using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExWebApiProjec.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}