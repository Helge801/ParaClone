using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParaClone
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "REAL SOLUTIONS", "FOR GYMS MEMBERS","THE LATEST", "PARAMOUNT CUSTOMER SERVICE",
                                  "Paramount Acceptance is here to help you","ABOUT","PARAMOUNT","Paramount Acceptance provides software and billing services in the fitness industry. With over 40 years of experience, Paramount is dedicated to serving our client’s customers with anything they need. From changing personal billing information to resolving a disputed charge, we are committed to helping you resolve any issues that might arise.",
                                  "CONTACT","PARAMOUNT","Please fill out the form below with your inquiry.","A customer service representative will respond as soon as possible","PAY ONLINE NOW",
                                  "Need to make a payment? Well now you can online.","Click on the button below to quickly make a payment today.",
                                  "CONTACT INFORMATION","Contact us","PO BOX 12345 Somewhere","800.555.5555"};
        }
    }
}
