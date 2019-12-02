using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_JSONClient
{
    [DataContract]
    public class RepresentativeList
    {
        [DataMember (Name = "results")]
        public ObservableCollection<Representative> Representatives {get; set;}
    }
}
