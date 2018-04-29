using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    [Serializable]
    public class NewsInfo
    {
        public int NewsId { get; set; }
        public int TypeId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime PubTime { get; set; }
    }
}
