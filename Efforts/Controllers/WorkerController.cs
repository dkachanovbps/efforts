using Efforts.Models;
using Efforts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Efforts.Controllers
{
    /// <summary>
    /// API controller for Workers
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly WorkerService _workerService;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="workerService"></param>
        public WorkerController([FromServices] WorkerService workerService)
        {
            _workerService = workerService;
        }

        /// <summary>
        /// get list of workers
        /// </summary>
        /// <param name="activeOnly">get only active workers</param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Worker> Get(bool activeOnly = false)
        {
            return _workerService.GetWorkers(activeOnly);
        }

        /// <summary>
        /// get Worker details by id
        /// </summary>
        /// <param name="id">unique identifier</param>
        /// <returns></returns>
        // GET api/<WorkerController>/5
        [HttpGet("{id}")]
        public Worker Get(int id)
        {
            return _workerService.GetWorkerById(id);
        }

        //// POST api/<WorkerController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<WorkerController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<WorkerController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
