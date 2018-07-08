using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6
{
    class PdaItem
    {
        //public string Name { get; set; }    
        public DateTime LastUpdated { get; set; }
        protected Guid ObjectKey { get; set; }
        public virtual string Name { get; set; }

        private string _Name;

        public PdaItem(string name)     //생성자
        {
            Name = name;
        }
       
    }
    //봉인 클래스
    public sealed class CommandLineParser
    {
        ///
    }
}
