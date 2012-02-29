using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace KWTechnologies.CapturePool.Core.Models
{
    public class Conference
    {
        [Key, Required]
        public Int32 Id { get; set; }

        [Required]
        public String Name { get; set; }

        public virtual List<Team> Teams { get; set; }
    }
}
