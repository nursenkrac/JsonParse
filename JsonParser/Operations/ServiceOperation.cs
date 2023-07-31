using JsonParser.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace JsonParser.Operations
{
    public class ServiceOperation
    {
       
        public String[] JsonParse()
        {
            JsonModel ou = new JsonModel();
            String[] strlist;
            try
            {
                string jsonData = File.ReadAllText("response.json");
                List<JsonModel> myDeserialized = JsonConvert.DeserializeObject<List<JsonModel>>(jsonData);
                char[] spearator = { '\n'};
                strlist = myDeserialized[0].description.Split(spearator);
            }
            catch (Exception ex)
            {
               
                throw;
            }

            return strlist;
        }
    }
}
