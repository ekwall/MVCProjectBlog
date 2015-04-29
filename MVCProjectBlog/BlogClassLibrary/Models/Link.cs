using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLibrary
{
    public class Link
    {
        public int Id { get; set; }
        public string HyperLink { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
