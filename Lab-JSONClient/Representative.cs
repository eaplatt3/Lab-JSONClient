using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_JSONClient
{
    [DataContract]
    public class Representative
    {
        string name;
        string party;
        string state;
        string district;
        string phone;
        string office;
        string link;

        [DataMember(Name = "name")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;

            }

        }

        [DataMember(Name = "party")]
        public string Party
        {
            get
            {
                return party;
            }

            set
            {
                party = value;

            }
        }

        [DataMember(Name = "state")]
        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;

            }
        }

        [DataMember(Name = "district")]
        public string District
        {
            get
            {
                return district;
            }

            set
            {
                district = value;

            }
        }

        [DataMember(Name = "phone")]
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;

            }
        }

        [DataMember(Name = "office")]
        public string Office
        {
            get
            {
                return office;
            }

            set
            {
                office = value;

            }
        }

        [DataMember(Name = "link")]
        public string Link
        {
            get
            {
                return link;
            }

            set
            {
                link = value;

            }
        }
    }
}
