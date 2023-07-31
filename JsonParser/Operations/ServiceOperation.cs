using JsonParser.Models;
using JsonParser.Models.ViewModels.Outputs;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace JsonParser.Operations
{
    public class ServiceOperation
    {
       
        public JsonModel GetById()
        {
            JsonModel ou = new JsonModel();
            try
            {
                string jsonData = File.ReadAllText("response.json");
                ou = JsonConvert.DeserializeObject<JsonModel>(jsonData);
                //string j = JsonSerializer.Deserialize<JsonModel>(jsonData);
                ou = System.Text.Json.JsonSerializer.Deserialize<JsonModel>(jsonData);
            }
            catch (Exception ex)
            {
               
                throw;
            }


            return ou;
        }
    }
}
