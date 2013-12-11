namespace Viksi.Web.Api.Controllers
{
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using Viksi.Models;
    using Viksi.Web.Api.ViewModels;

    public class BrokersController : BaseController
    {
        [HttpPost]
        [ActionName("register")]
        public HttpResponseMessage Register(BrokerRegisterViewModel model)
        {
            if (db.Brokers.All().Any(b => b.Email.ToLower() == model.Email.ToLower()))
            {
                return ExistingEntryError("Email", "There is already a broker using that email address");
            }

            var sessionKey = GenerateSessionKey(model.Email);

            Broker broker = new Broker()
                {
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Password = StringToSha1(model.Password)
                };

            db.Brokers.Add(broker);
            db.SaveChanges();

            var loggedIn = new BrokerLoggedInViewModel
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                SessionKey = sessionKey
            };

            return Request.CreateResponse(HttpStatusCode.Created, loggedIn);
        }
    }
}