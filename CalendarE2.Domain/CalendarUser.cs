using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CalendarE2.Domain
{
    public class CalendarUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AdminLevel AdminLevel { get; set; } 

        public int AdminLevelId { get; set; }
    }
}
