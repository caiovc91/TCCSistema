using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCCSistema.Models
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_login { get; set; }
        [ForeignKey("User")]
        public int id_user { get; set; }
        public virtual User User { get; set; }
        public ICollection<User> Users { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
