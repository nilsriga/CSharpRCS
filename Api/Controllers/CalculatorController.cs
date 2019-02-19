using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class CalculatorController : ApiController
    {

        [HttpGet]
        public int Calculate(string number1, string number2, string op)
        {

            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            var result = 0;

            switch (op)
            {
                case "times":
                    result = num1 * num2;
                    break;
                case "divide":
                    result = num1 / num2;
                    break;
                case "plus":
                    result = num1 + num2;
                    break;
                case "minus":
                    result = num1 - num2;
                    break;
            }
            return result;
            // serveris darbojas fonā tikai tad, ja viņš ir palaists serveris bez debug augšā pie "debug"
        }










        /* // GET api/values
         public IEnumerable<string> Get()
         {
             return new string[] { "value1", "value2" };
         }

         // GET api/values/5
         public string Get(int id)
         {
             return "value";
         }

         // POST api/values
         public void Post([FromBody]string value)
         {
         }

         // PUT api/values/5
         public void Put(int id, [FromBody]string value)
         {
         }

         // DELETE api/values/5
         public void Delete(int id)
         {
         }
         */
    }
}
