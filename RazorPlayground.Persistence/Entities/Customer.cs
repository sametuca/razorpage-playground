using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPlayground.Persistence.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobilePhoneCountryCode { get; set; }
        public string MobilePhone { get; set; }
        public string MailAddress { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int RideCount { get; set; }
        public DateTime LastActivityDate { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public bool? IsTcknValidated { get; set; }
        public bool IsTcknBanned { get; set; }
        public string Tckn { get; set; }
        public string OneSignalId { get; set; }
        public bool IsAnonymized { get; set; }
    }
}
