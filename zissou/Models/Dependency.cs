using zissou.Enums;
using zissou.Interfaces;

namespace zissou.Models
{
    public class Dependency : IRequest {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public Status Status { get; set; }

        bool IRequest.IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}