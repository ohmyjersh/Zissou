using System;
using System.Collections.Generic;

namespace zissou
{
    interface IRequest {
        bool IsValid();
    }
    public class RegisterRequest : IRequest
    {
        public string Name { get; set; }
        public string Server { get; set; }
        public List<Dependency> Dependencies { get; set; }
        public Dictionary<string, string> Metadata { get; set; }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }

    public class Dependency : IRequest {
        public string Name { get; set; }
        public string Version { get; set; }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
