using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace TypeBloodLogic
{
    public class BloodTypeService
    {
        private IConfiguration _configuration;
        public BloodTypeService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<BloodType> GetBlood()
        {
            string addressURL = _configuration.GetSection("bloodURL").Value;
            HttpClient client = new HttpClient();
            HttpResponseMessage reponse = await client.GetAsync(addressURL);

            BloodType bloodType;
            string responseData = await reponse.Content.ReadAsStringAsync();
            bloodType = JsonConvert.DeserializeObject<BloodType>(responseData);
            /*if (reponse.IsSuccessStatusCode)
            {
                string responseData = await reponse.Content.ReadAsStringAsync();
                bloodType = JsonConvert.DeserializeObject<BloodType>(responseData);
            }
            else
            {
                bloodType = new BloodType();
            }*/

            return bloodType;
        }
    }
}
