using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakAwayConsole.Models
{
    public class Lodging
    {
        public int LodgingId { get; set; }
        public string LodgingName { get; set; }
        public string Owner { get; set; }
        public bool IsResort { get; set; }
        [ForeignKey("Destination")]
        public int Lodging_DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
