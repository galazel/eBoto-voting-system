using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBoto.Models
{
    internal class Election
    {
        private int ElectionID { get; set; }
        private string ElectionName { get; set; }
        private string Department { get; set; }
        private string Description { get; set; }    
        private Boolean isVoted { get; set; }

    }
}
