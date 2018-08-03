using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Claim claim1 = new Claim(1, "Car", "Car Accident", 5000.00, "12/21/2012", "12/31/2012");
            Claim claim2 = new Claim(2, "Home", "House Fire", 7500.00, "01/15/2013", "02/24/2013");
            Claim claim3 = new Claim(3, "Theft", "Car Theft", 15000.00, "02/12/2013", "04/29/2013");
            Claim claim4 = new Claim(4, "Car", "Car Accident", 500.00, "03/19/2013", "04/30/2013");
            Claim claim5 = new Claim(5, "Home", "Burst Water Main", 6000.00, "04/06/2013", "06/20/2013");

            ClaimRepository claimRepo = new ClaimRepository();

            claimRepo.AddToQueue(claim1);
            claimRepo.AddToQueue(claim2);
            claimRepo.AddToQueue(claim3);
            claimRepo.AddToQueue(claim4);
            claimRepo.AddToQueue(claim5);

            Queue<Claim> claims = claimRepo.GetQueue();
            while(true)
            {
                Console.WriteLine("Enter the NUMBER you would like to select:\n" +
                    "1. List All Queued Items\n" +
                    "2. Add Item to Queue\n" +
                    "3. View Next Item in Queue\n" +
                    "4. Remove Item from Queue\n" +
                    "5. Exit Program\n");

                string optionAsString = Console.ReadLine();
                int option = int.Parse(optionAsString);

                if(option == 1)
                {
                    foreach(Claim claim in claims)
                    {
                        Console.WriteLine($"Claim Number: {claim.ClaimID}\n" +
                            $"Claim Type: {claim.ClaimType}\n" +
                            $"Claim Description: {claim.Description}\n" +
                            $"Claim Amount: {claim.ClaimAmount}\n" +
                            $"Date of Incident: {claim.DateOfIncident} \n" +
                            $"Date of Claim: {claim.DateOfClaim} \n" +
                            $"Validity: {claim.IsValid} \n");
                    }
                }

                if(option == 2)
                {
                    while(true)
                    {
                        Console.WriteLine("Enter a claim ID: ");
                        int claimid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter a claim type: ");
                        string claimtype = Console.ReadLine();
                        Console.WriteLine("Enter a claim description: ");
                        string claimdescription = Console.ReadLine();
                        Console.WriteLine("Enter a claim amount: ");
                        double claimamount = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the incident date: ");
                        string dateofincident = Console.ReadLine();
                        Console.WriteLine("Enter the claim date: ");
                        string dateofclaim = Console.ReadLine();
                        
                        Claim userclaim = new Claim(claimid, claimtype, claimdescription, claimamount, dateofincident, dateofclaim);
                        claimRepo.AddToQueue(userclaim);

                        Console.WriteLine("Would you like to add another claim?: y/n");
                        string response = Console.ReadLine();
                        response = response.ToLower();
                        if(response == "y") { }
                        else if(response == "n")
                        {
                            break;
                        }
                    }
                }

                if(option == 3)
                {
                    Claim peekedclaim = claimRepo.LookAtNextItem();
                    Console.WriteLine($"Claim ID: {peekedclaim.ClaimID}\n" +
                        $"Claim Type: { peekedclaim.ClaimType}\n" +
                            $"Claim Description: {peekedclaim.Description}\n" +
                            $"Claim Amount: {peekedclaim.ClaimAmount}\n" +
                            $"Date of Incident: {peekedclaim.DateOfIncident} \n" +
                            $"Date of Claim: {peekedclaim.DateOfClaim} \n" +
                            $"Validity: {peekedclaim.IsValid} \n");
                }

                if(option == 4)
                {
                    while(true)
                    {
                        Console.WriteLine("Would you like to finish the first claim? y/n");
                        string response = Console.ReadLine();
                        response = response.ToLower();
                        if(response == "y")
                        {
                            claimRepo.RemoveFromQueue();
                        }
                        if (response == "n")
                        { }

                        Console.WriteLine("Would you like to finish the next item?: y/n");
                        string response1 = Console.ReadLine();
                        response1 = response1.ToLower();
                        if(response1 == "y") { }
                        if(response1 == "n")
                        {
                            break;
                        }
                        
                    }
                }

                if(option == 5)
                {
                    break;
                }
            }
        }
    }
}
