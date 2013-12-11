namespace Viksi.Web.Api.ViewModels
{
    using System.Runtime.Serialization;
    
    [DataContract]
    public class BrokerLoggedInViewModel
    {
        [DataMember(Name="email")]
        public string Email { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "LastName")]
        public string LastName { get; set; }

        [DataMember(Name = "sessionKey")]
        public string SessionKey { get; set; }
    }
}