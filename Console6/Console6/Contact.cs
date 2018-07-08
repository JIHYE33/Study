using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console6
{
    class Contact : PdaItem 
    {
        public Contact(string name) : base(name)
        {
            Name = name;
        }

        public string Address { get; set; }

        public string Phone { get; set;  }

        public void Load(PdaItem pdaItem)
        {
            //pdaItem.ObjectKey 
            //보호 수준으로 인해 액세스 하지 못함

            Contact contact = pdaItem as Contact;
            contact.ObjectKey = new Guid();

        }

        public override string Name
        {
            get { return FirstName+" "+LastName ; }
            set
            {
                string[] names = value.Split(' ');
                FirstName = names[0];
                LastName = names[1];
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
