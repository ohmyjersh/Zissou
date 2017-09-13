using zissou.Interfaces;

namespace zissou.Models
{
    public class Dependency : IRequest {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Status { get; set;}

        bool IRequest.IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}