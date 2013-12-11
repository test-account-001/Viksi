namespace Viksi.Web.Api.Controllers
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Security.Cryptography;
    using System.Web.Http;
    using Viksi.Data;

    public class BaseController : ApiController
    {
        protected readonly IViksiData db;

        public BaseController()
            : this(new ViksiData())
        { }

        public BaseController(IViksiData context)
        {
            if (context == null)
            {
                throw new NullReferenceException("context cannot be null!");
            }

            this.db = context;
        }

        protected HttpResponseMessage ExistingEntryError(string propertyName, string message)
        {
            var err = new ArgumentException(propertyName, message);
            return Request.CreateErrorResponse(HttpStatusCode.Conflict, err);
        }

        protected string StringToSha1(string text)
        {
            System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();

            byte[] buffer = encoder.GetBytes(text);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");

            return hash;
        }

        protected string GenerateSessionKey(string userName)
        {
            return StringToSha1(string.Format("{0}{1}", DateTime.Now, new Random().Next(0, 1000)));
        }
    }
}