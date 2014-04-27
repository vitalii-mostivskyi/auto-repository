using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace car_shop_administrative__program.DBConnection
{
    [Database]
    public class carshop_db: DataContext
    {
        carshop_db() : base(Properties.Resources.ConnectionString) { }

       /* public Table<User> Users;
        public Table<InOutRegister> InOutRegisters;
        public Table<ActionRegister> ActionRegisters;
        public Table<Question> Questions;
        public Table<Answers> AllAnswers;
        */
        public static carshop_db Instance = new carshop_db();
    }
}
