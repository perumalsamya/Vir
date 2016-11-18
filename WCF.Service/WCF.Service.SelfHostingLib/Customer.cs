using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF.Service
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public int AGE { get; set; }
        [DataMember]
        public string ADDRESS { get; set; }
        [DataMember]
        public string DESCRIPTION { get; set; }
    }
}