using System.Collections.Generic;
using System.Web.Http;

namespace WebAPI.Controllers
{
    /// <summary>
    /// The default API controller
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Gets all values
        /// </summary>
        /// <returns>value for each row</returns>
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get value by Id
        /// </summary>
        /// <param name="id">Id of value to return</param>
        /// <returns>value</returns>
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
    }
}
