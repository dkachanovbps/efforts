using Efforts.Dal;
using Efforts.Models;
using System.Collections.Generic;

namespace Efforts.Services
{
    /// <summary>
    /// service for workers
    /// </summary>
    public class WorkerService
    {
        private readonly EffortsDal _efforts;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="efforts"></param>
        public WorkerService(EffortsDal efforts)
        {
            _efforts = efforts;
        }

        /// <summary>
        /// returns list of workers with details
        /// </summary>
        /// <param name="onlyActive">select only active workers</param>
        /// <returns>list of Worker</returns>
        public IEnumerable<Worker> GetWorkers(bool onlyActive)
        {
            return _efforts.GetWorkers(onlyActive);
        }

        /// <summary>
        /// returns worker details by id
        /// </summary>
        /// <param name="id">unique identifier</param>
        /// <returns>Worker object</returns>
        public Worker GetWorkerById(int id)
        {
            return _efforts.GetWorkerById(id);
        }
    }
}
