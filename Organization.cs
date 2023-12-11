using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubApplicationProgram
{
    internal abstract class Organization
    {
        public string OrgName { get; set; }
        public string PrimaryContact { get; set; }
        public double fundedAmount { get; set; }


        public Organization()

        {

        }

        public Organization(string OrgName, string PrimaryContact)

        {
            this.OrgName = OrgName;
            this.PrimaryContact = PrimaryContact;
        }

        public abstract string GetMeetingLocation();
        public abstract string GetMeetingDay();
        public abstract string GetMeetingTime();
    }
}
