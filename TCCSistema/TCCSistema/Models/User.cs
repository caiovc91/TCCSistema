using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCCSistema.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_user{ get; set; }

        [Required(ErrorMessage = "Required.")]
        public string name { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string? email { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string phone { get; set; }
        public string? info { get; set; }
        public string? role { get; set; }
        [ForeignKey("UserType")]
        public int id_user_type { get; set; }
        public virtual UserType UserType { get; set; }
        public bool? isPatient { get; set; }
    }
}
