using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCCSistema.Models
{
    public class OccurrenceLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_occurrence { get; set; }
        public DateTime occurdate { get; set; }
        [ForeignKey("Camera")]
        public int id_camera { get; set; }
        public virtual Camera Camera { get; set; }
        public int id_user { get; set; }
        public virtual User User { get; set; }
        public int id_image { get; set; }
        public virtual ImageLog ImageLog { get; set; }
    }
}
