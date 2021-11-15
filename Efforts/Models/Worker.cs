using System;

namespace Efforts.Models
{
    /// <summary>
    /// Worker class
    /// </summary>
    public class Worker
    {
        /// <summary>
        /// unique identifier
        /// </summary>
        public int Id { set; get; }
        /// <summary>
        /// First Name + Last Name
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// Login
        /// </summary>
        public string Login { set; get; }
        /// <summary>
        /// EMail address
        /// </summary>
        public string Email { set; get; }
        /// <summary>
        /// date of work start
        /// </summary>
        public DateTime DateBeg { set; get; }
        /// <summary>
        /// date of work end
        /// </summary>
        public DateTime? DateEnd { set; get; }
        /// <summary>
        /// Administrator
        /// </summary>
        public bool IsAdmin { set; get; }
        /// <summary>
        /// Working status
        /// </summary>
        public string Status { set; get; }
        /// <summary>
        /// Author creation
        /// </summary>
        public string AuthorCreate { set; get; }
        /// <summary>
        /// Author of last modification
        /// </summary>
        public string AuthorLastModif { set; get; }
        /// <summary>
        /// Date of creation
        /// </summary>
        public DateTime DateCreate { set; get; }
        /// <summary>
        /// Date of last modification
        /// </summary>
        public DateTime DateLastModif { set; get; }
    }
}
