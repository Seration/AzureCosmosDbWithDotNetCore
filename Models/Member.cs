using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureCosmosDbExample.Models
{
    public class Member
    {
        public Member()
        {
            RegisterDate = DateTime.Now;
        }


        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "registerDate")]
        public DateTime RegisterDate { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
