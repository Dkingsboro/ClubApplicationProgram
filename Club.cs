using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubApplicationProgram
{
    internal class Club : Organization, IFunding
    {
        public string MeetingLocation { get; set; }
        public string MeetingDay { get; set; }
        public string MeetingTime { get; set; }

        public Club(string MeetingLocation, string MeetingDay, string MeetingTime, string OrgName, string PrimaryContact)
            : base(OrgName, PrimaryContact)
        {
            this.MeetingLocation = MeetingLocation;
            this.MeetingDay = MeetingDay;
            this.MeetingTime = MeetingTime;
        }

        public override string GetMeetingLocation()
        {
            return MeetingLocation;
        }

        public override string GetMeetingDay()
        {
            return MeetingDay;
        }

        public override string GetMeetingTime()
        {
            return MeetingTime;
        }

        public void SetFundingAmt(double amount)
        {
            fundedAmount = amount;
            Console.WriteLine($"The funded amount is {amount:C}\n");
        }

        public override string ToString() =>

        $"\nClub: {base.OrgName}" +
        $"\nMeeting Location {MeetingLocation}" +
        $"\nClub Contact: {base.PrimaryContact}" +
        $"\nMeeting Date: {MeetingDay}" +
        $"\nMeeting Time: {MeetingTime}\n";
    }
}
