using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsletterAppMVC.ViewModels
{
    public class SignupVm
    {
        // Maps to data we want to display from newsletter DB
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}