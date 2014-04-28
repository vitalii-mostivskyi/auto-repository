using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace car_shop_administrative__program.DBConnection.Entities
{
    [Table]
    public class Car
    {
        [Column(IsPrimaryKey = true)]
        public Guid id { get; set; }

        [Column]
        public string model { get; set; }

        [Column]
        public string marka { get; set; }

        [Column]
        public Guid categoryId { get; set; }

        [Column]
        public string description { get; set; }

        [Column]
        public int quantity { get; set; }

        [Column]
        public decimal price { get; set; }

        [Column]
        public DateTime creationDate { get; set; }

        private EntityRef<Category> _category;
        [Association(Name = "FK_Car_Category", IsForeignKey = true, Storage = "_category", ThisKey = "categoryId")]
        public Category Category
        {
            get { return _category.Entity; }
            set { _category.Entity = value; }
        }

        public string GetName()
        {
            return String.Format("{1} - {0}", model, marka);
        }
    }
}
