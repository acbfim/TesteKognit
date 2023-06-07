using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kognito.domain.Dtos
{
    public class CreateUser
    {
        public string FullName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Cpf { get; set; }
    }
}