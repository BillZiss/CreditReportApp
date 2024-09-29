using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditReportApp.Models
{
    public class CreditRow
    {
        public CreditRow(int id, string firstName, string lastName, string creditAgency, int creditScore, int age, string state, string occupation)
        {
            Id  = id;
            FirstName = firstName;
            LastName = lastName;
            CreditAgency = creditAgency;
            CreditScore = creditScore;
            Age = age;
            State = state;
            Occupation = occupation;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreditAgency { get; set; }
        public int CreditScore { get; set; }
        public int Age { get; set; }
        public string State { get; set; }
        public string Occupation { get; set; }
    }
}
