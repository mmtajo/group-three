using pcso_group_three.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace pcso_group_three.Services
{
    public class OfficerService
    {
        HttpClient httpClient;
        List<Officer> officerList = new ();

        public OfficerService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Officer>> GetOfficers()
        { 
            if(officerList?.Count > 0)
                return officerList;

            string requestURL = "https://pcso-group3-backend.azurewebsites.net/officers";

            try
            {
                var response = await httpClient.GetAsync(requestURL);

                if (response.IsSuccessStatusCode)
                {
                    officerList = await response.Content.ReadFromJsonAsync<List<Officer>>();
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return officerList;

        }
    }
}
