using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Hastane
    {
        [Key]
        public int hastane_id { get; set; }
        [StringLength(50)]
        public string hastane_ad { get; set; }
        [StringLength (50)]
        public string hastane_sehir { get; set; }
    }
}
