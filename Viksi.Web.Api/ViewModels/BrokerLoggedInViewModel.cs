﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Viksi.Web.Api.ViewModels
{
    public class BrokerLoggedInViewModel
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SessionKey { get; set; }
    }
}