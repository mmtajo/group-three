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
    public class OfficeService
    {
        HttpClient httpClient;
        List<Office> officeList = new();

        public OfficeService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Office>> GetOffices()
        {
            if (officeList?.Count > 0)
                return officeList;

            string requestURL = "https://pcso-linfred-backend.azurewebsites.net/api/Offices";

            try
            {
                var response = await httpClient.GetAsync(requestURL);

                if (response.IsSuccessStatusCode)
                {
                    officeList = await response.Content.ReadFromJsonAsync<List<Office>>();
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return officeList;

        }

        public async Task<List<Office>> GetOfficesByOfficeid(int officeID)
        {
            //if (officeList?.Count > 0)
            //    return officeList;

            string requestURL = "https://pcso-linfred-backend.azurewebsites.net/api/Offices/Officer/"+officeID;

            try
            {
                var response = await httpClient.GetAsync(requestURL);

                if (response.IsSuccessStatusCode)
                {
                    officeList = await response.Content.ReadFromJsonAsync<List<Office>>();
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return officeList;
            //return officeList.Where(s=>s.officeId==officeID).ToList();

        }
    }
}