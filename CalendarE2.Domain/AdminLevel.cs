using CalendarE2.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CalendarE2.Domain
{
    public class AdminLevel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminLevelId { get; set; }
        public int AdminLevelDesignation { get; set; }
        public string Description { get; set; }
        public ICollection<CalendarUser> Users { get; set; }
        
    }
}
