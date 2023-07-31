using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonParser.Models
{

    public class BoundingPoly
    {
        public List<Vertex> vertices { get; set; }
    }

    public class JsonModel
    {
        public string locale { get; set; }
        public string description { get; set; }
        public BoundingPoly boundingPoly { get; set; }
    }

    public class Vertex
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class OutputModel
    {
        public String[] strlist { get; set; }
    }
}
