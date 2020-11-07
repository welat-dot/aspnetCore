using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class ForLoginDto: IDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DataBaseName { get; set; } = null;
    }
}
