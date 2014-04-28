using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using car_shop_administrative__program.DBConnection.Entities;

namespace car_shop_administrative__program.DBConnection
{
    [Database]
    public class carshop_db: DataContext
    {
        carshop_db() : base(Properties.Resources.ConnectionString) { }

        public Table<User> Users;
        public Table<Category> Categories;
        public Table<Order> Orders;
        public Table<Car> Cars;
        
        public static carshop_db Instance = new carshop_db();
    }
}
