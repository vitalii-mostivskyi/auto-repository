using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace VasiliyCarsSyte.Code
{
    public class DataLib
    {
        protected string _conectionString;


        public DataLib(string conectionString) { this._conectionString = conectionString; }
        public List<Category> getCategory()
        {
            using (SqlConnection com = new SqlConnection(_conectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from Category order by name;", com);
                com.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Category> list = new List<Category>();
                while (reader.Read())
                {
                    Category category = new Category();
                    category.id = reader.GetGuid(0);
                    category.name = reader.GetString(1);


                    list.Add(category);

                }
                return list;
            }
        }
        public List<Car> getCarBelongToCategory(string idCategory)
        {
            using (SqlConnection com = new SqlConnection(_conectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from Car where (Car.categoryId='"+idCategory+"') order by model;", com);
                com.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Car> list = new List<Car>();
                while (reader.Read())
                {
                    Car car = new Car();
                    car.id = reader.GetGuid(0);
                    car.model  = reader.GetString(1);
                    car.mark = reader.GetString(2);
                    car.discription = reader.GetString(4);
                    car.quantity = reader.GetInt32(5);
                    car.price = reader.GetDecimal(6);
                    car.crearoDate = reader.GetDateTime(7);

                    list.Add(car);

                }
                return list;
            }
        }
        public Car getCar(string id)
        {
            using (SqlConnection com = new SqlConnection(_conectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from Car where (Car.id='" + id + "') order by model;", com);
                com.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Car> list = new List<Car>();
                Car car = new Car();
                while (reader.Read())
                {
                    
                    car.id = reader.GetGuid(0);
                    car.model = reader.GetString(1);
                    car.mark = reader.GetString(2);
                    car.discription = reader.GetString(4);
                    car.quantity = reader.GetInt32(5);
                    car.price = reader.GetDecimal(6);
                    car.crearoDate = reader.GetDateTime(7);

               

                }
                return car;
            }
        }
        public int setNewUser(Guid id ,string name, string surname, string address ,string phone)
        {
             using (SqlConnection com = new SqlConnection(_conectionString))
            {
                string statement = "insert into [User] (id,name,surname,[address],phone,userType) values ('" + id + "','" + name + "','" + surname + "','" + address + "','" + phone + "','Costumer')";
                SqlCommand cmd = new SqlCommand(statement, com);
                com.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        public int setOrder(string carid, int carcount, string userid)
        {
            using (SqlConnection com = new SqlConnection(_conectionString))
            {
                string statement = "insert into [Order] (id,carId,orderDate,carCount,userId,success) values ('" + Guid.NewGuid() + "','" + carid + "','" + DateTime.Now.ToString() + "','" + carcount + "','" + userid + "','false')";
                SqlCommand cmd = new SqlCommand(statement, com);
                com.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }

    public class Category
    {
        public Guid id;
        public string name;
    }
    public class Car
    {
        public Guid id;
        public string model;
        public string mark;
        public Guid categoryId;
        public string discription;
        public int  quantity;
        public decimal  price;
        public DateTime crearoDate;

    }
    public class User
    {
        
        public string name;
        public string surname;
        public string phone;
        public string address;
     

    }

}