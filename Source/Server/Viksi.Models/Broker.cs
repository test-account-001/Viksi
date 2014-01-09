namespace Viksi.Models
{
    using System.Collections.Generic;

    public class Broker
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string SessionKey { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }

        public int AgencyId { get; set; }

        public virtual Agency Agency { get; set; }

		
        public Broker()
        {
            this.Phones = new HashSet<Phone>();
        }		
    }
}