using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBoto.Models
{
    internal class Voter
    {
        private int VoterID { get; set; }
        private string FirstName { get; set; }
        
        private string MiddleName { get; set; }
        private string LastName { get; set; }
        private DateTime BirthDate { get; set; }
        private string ContactNumber { get; set; }
        private string Email { get; set; }
        private string Gender { get; set; }
        private string Province { get; set; }
        private string City { get; set; }
        private string Barangay { get; set; }
        private string SchoolYear { get; set; }
        private string Section { get; set; }
        private int DepartmentID { get; set; }
        private int VotedID { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private Boolean isVoted { get; set; }


    }
}
