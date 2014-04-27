using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace car_shop_administrative__program.DBConnection.Entities
{
    [Table]
    public class User
    {

        [Column(IsPrimaryKey = true)]
        public Guid id { get; set; }
        
        [Column]
        public string name { get; set; }

        [Column]
        public string surname { get; set; }

        [Column]
        public string phone { get; set; }

        [Column]
        public string address { get; set; }

        [Column]
        public string password { get; set; }

        [Column]
        public string userType { get; set; }
    }
}
