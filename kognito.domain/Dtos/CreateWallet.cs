using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kognito.domain.Dtos
{
    public class CreateWallet
    {
        public long UserId { get; set; }
        public long Amount { get; set; }
        public string Bank { get; set; }
    }
}