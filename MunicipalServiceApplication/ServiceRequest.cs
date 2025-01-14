using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication
{
    public partial class ServiceRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }

        public ServiceRequest(int id, string description, string status, DateTime dateCreated)
        {
            Id = id;
            Description = description;
            Status = status;
            DateCreated = dateCreated;
        }
    }
}

