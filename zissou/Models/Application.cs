
using System;
using System.Collections.Generic;
using zissou.Interfaces;

namespace zissou.Models
{
    public class Application : IRequest
    {
        public string Name { get; set; }
        public string Server { get; set; }
        public string Version { get; set; }
        public List<Dependency> Dependencies {get; set;}
        public Dictionary<string, string> Metadata { get; set; }
        bool IRequest.IsValid()
        {
            throw new NotImplementedException();
        }
    }
}