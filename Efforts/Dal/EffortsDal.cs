using Dapper;
using Efforts.Configuration;
using Efforts.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Efforts.Dal
{
    /// <summary>
    /// data layer for Efforts DB
    /// </summary>
    public class EffortsDal
    {
        private readonly string _connString;

        /// <summary>
        /// constructor
        /// </summary>
        public EffortsDal(IOptions<ConnectionStrings> connectionStrings)
        {
            _connString = connectionStrings?.Value.Efforts ?? throw new ArgumentNullException(nameof(connectionStrings));
        }

        /// <summary>
        /// get workers list with details
        /// </summary>
        /// <param name="onlyActive">get only active workers</param>
        /// <returns></returns>
        public IEnumerable<Worker> GetWorkers(bool onlyActive = false)
        {
            using IDbConnection db = new SqlConnection(_connString);
            db.Open();
            var workers = db.Query<Worker>("select * from Worker where  (@onlyActive = 0 or DateEnd IS NULL OR DateEnd > getdate())", new { onlyActive }).ToList();
            return workers;
        }

        /// <summary>
        /// get workers list with details
        /// </summary>
        /// <param name="id">unique identifier</param>
        /// <returns></returns>
        public Worker GetWorkerById(int id)
        {
            using IDbConnection db = new SqlConnection(_connString);
            db.Open();
            return db.Query<Worker>("select * from Worker where id = @id", new { id }).FirstOrDefault();
        }
    }
}
