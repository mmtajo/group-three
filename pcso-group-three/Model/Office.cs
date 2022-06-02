using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcso_group_three.Model
{
    public partial class Office
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? position { get; set; }
        public string? department { get; set; }
        public string? imageURL { get; set; }
        public byte[]? image { get; set; } = null;
        public string? description { get; set; }
        public int officeId { get; set; }
        public DateTime created { get; set; }
    }
}
