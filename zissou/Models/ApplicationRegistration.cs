
using System;
using System.Collections.Generic;
using zissou.Interfaces;

namespace zissou.Models
{
    public class Register : Health, IRequest
    {
        public string Name { get; set; }
        public string Server { get; set; }
        public string Version {get; set;}
        public Dictionary<string, string> Metadata { get; set; }
        bool IRequest.IsValid()
        {
            throw new NotImplementedException();
        }
    }
}