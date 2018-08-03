using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class Claim
    {
        public Claim(int claimid, string claimtype, string description, Double claimamount, string dateofincident, string dateofclaim)
        {
            ClaimID = claimid;
            ClaimType = claimtype;
            Description = description;
            ClaimAmount = claimamount;
            DateOfIncident = DateTime.Parse(dateofincident);
            DateOfClaim = DateTime.Parse(dateofclaim);
            IsValid = (DateOfClaim - DateOfIncident).TotalDays < 30;

        }

        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public Double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }
    }
}
