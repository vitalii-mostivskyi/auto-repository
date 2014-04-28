using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.code
{
    public class BasketFilling
    {
        public string idUser;
        public List<String> idWares;

        public BasketFilling() { }
        public BasketFilling(string idUser, List<String> idWares)
        {
            this.idUser = idUser;
            this.idWares = idWares;
        }
    }

    public class Basket : BasketFilling
    {
        protected static List<BasketFilling> list = new List<BasketFilling>();



        public static void AddUser(string idUser)
        {
            list.Add(new BasketFilling(idUser, new List<String>()));

        }
        public static void AddUserWare(string idUser, string idWare)
        {
            foreach (BasketFilling user in list)
            {
                if (user.idUser == idUser)
                {
                    foreach (var value in user.idWares)
                    {
                        if (value == idWare)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    }
                    user.idWares.Add(idWare);
                    break;
                }
            }
        }
        public static void DeleteUserWare(string idUser, string idWare)
        {
            foreach (BasketFilling user in list)
            {
                if (user.idUser == idUser)
                {
                    user.idWares.Remove(idWare);
                }
                break;
            }
        }
        public static void DeleteUser(string idUser)
        {
            foreach (var value in list)
            {
                if (value.idUser == idUser) { list.Remove(value); break; }
            }

        }
        public static List<string> GetWaresUser(string idUser)
        {

            foreach (var value in list)
            {
                if (value.idUser == idUser)
                {
                    return value.idWares;
                }

            }
            return null;
        }
        public static bool IsUserExist(string idUser)
        {
            foreach (var value in list)
            {
                if (value.idUser == idUser)
                {
                    return true;
                }

            }
            return false;
        }
    }



}