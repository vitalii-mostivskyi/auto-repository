using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace car_shop_administrative__program.DBConnection.Entities
{
    [Table]
    public class Order
    {
        [Column(IsPrimaryKey = true)]
        public Guid id { get; set; }

        [Column]
        public Guid carId { get; set; }

        [Column]
        public Guid userId { get; set; }

        [Column]
        public DateTime orderDate { get; set; }

        [Column]
        public int carCount { get; set; }

        [Column]
        public bool success { get; set; }


        private EntityRef<User> _user;
        [Association(Name = "FK_Order_User", IsForeignKey = true, Storage = "_user", ThisKey = "userId")]
        public User User
        {
            get { return _user.Entity; }
            set { _user.Entity = value; }
        }

        private EntityRef<Car> _car;
        [Association(Name = "FK_Order_Car", IsForeignKey = true, Storage = "_car", ThisKey = "carId")]
        public Car Car
        {
            get { return _car.Entity; }
            set { _car.Entity = value; }
        }


        public decimal GetOrderTotalSum()
        {
            return carCount * Car.price;
        }
   
    }
}
