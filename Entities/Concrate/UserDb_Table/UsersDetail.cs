using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrate.UserDb_Table
{
    public class UsersDetail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [MaxLength(15)]
        public string TelNo { get; set; }
        [MaxLength(15)]
        public string IBAN { get; set; }

    }
}
