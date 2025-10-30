using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBoto
{
    internal class Elec
    {
        public static int ElectionId { get; set; }
        public static int DepartmentId { get; set; }

        public static IList<CandidateModel> _list = new List<CandidateModel>();

    }
}
