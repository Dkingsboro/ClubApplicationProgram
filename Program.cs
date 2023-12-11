namespace ClubApplicationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string clubName;
            string meetingLocation;
            string clubContact;
            string meetingTime;
            string meetingDate;
            double fundingAmount;


            Console.Write("Enter the club name: ");
            clubName = Console.ReadLine();

            Console.Write("enter the Meeting Location: ");
            meetingLocation = Console.ReadLine();

            Console.Write("Enter the club contact: ");
            clubContact = Console.ReadLine();

            Console.Write("Enter the Meeting Date: ");
            meetingDate = Console.ReadLine();

            Console.Write("Enter the Meeting time: ");
            meetingTime = Console.ReadLine();

            Console.Write("Enter the funding amount: ");
            fundingAmount = double.Parse(Console.ReadLine());

            Club c1 = new Club("Club House", "March 20th", "7:00PM", "Bridge Players", "Dylan Kingsboro");           
            Console.Write(c1);
            c1.SetFundingAmt(35450);

            Club c2 = new Club(meetingLocation, meetingDate, meetingTime, clubName,clubContact);
            Console.Write(c2);
            c2.SetFundingAmt(fundingAmount);
        }
    }
}