using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCCSistema.Models
{
    public class TargetUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [ForeignKey("User")]
        public int id_user1 { get; set; }
        public virtual User User1 { get; set; }
        [ForeignKey("User")]
        public int id_user2 { get; set; }
        public virtual User User2 { get; set; }
    }
}
