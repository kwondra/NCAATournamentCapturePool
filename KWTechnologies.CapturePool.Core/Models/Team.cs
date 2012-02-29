using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace KWTechnologies.CapturePool.Core.Models
{
    public class Team
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public Int32 ConferenceId { get; set; }
        public virtual Conference Conference { get; set; }
    }
}
