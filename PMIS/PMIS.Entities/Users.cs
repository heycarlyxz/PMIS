using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS.Entities
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public Guid UniqueId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmployeeId { get; set; }
    }
}
