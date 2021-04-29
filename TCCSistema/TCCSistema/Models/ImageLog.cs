using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCCSistema.Models
{
    public class ImageLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_image { get; set; }
        public DateTime record { get; set; }
        [ForeignKey("Camera")]
        public int id_camera { get; set; }
        public virtual Camera Camera { get; set; }
        public string image_name { get; set; }
        public int frame_number { get; set; }
        public int position_h { get; set; }
        public int position_v { get; set; }
        [ForeignKey("User")]
        public int id_user { get; set; }
        public virtual User User { get; set; }
        public string image_string { get; set; }
    }
}
