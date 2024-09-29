using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Threading.Tasks;
using CreditReportApp.Components;
using CreditReportApp.Models;
using Microsoft.AspNetCore.Components.Forms;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Components;

namespace CreditReportApp
{
    public static class DataService
    {
        public async static Task<List<CreditRow>> GetCreditRowsAsync()
        {
            var http = new HttpClient();
            string json = await http.GetStringAsync("http://localhost:5144/CreditRows.json");
            List<CreditRow> creditRows = JsonConvert.DeserializeObject<List<CreditRow>>(json);
            return creditRows;
        }

        public static CreditDetail GetCreditDetails()
        {
            CreditDetail creditDetail = new CreditDetail
            {
                Id = 23892389,
                Age = 37,
                Occupation = "welder",
                State = "OH"
            };

            return creditDetail;

        }
    }
}
