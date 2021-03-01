using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelBooking.Models
{
    public class UserDao
    {
        MyDbContext context = null; 

        public UserDao()
        {
            context = new MyDbContext();
        }
        public string Insert(User entiny)
        {
            context.Users.Add(entiny);
            context.SaveChanges();
            return entiny.Name;
        }
        public User GetID(string Name)
        {
            return context.Users.SingleOrDefault(X=>X.UserName == Name);

        }
        public bool Login(string userName , string Pass)
        {
            var result = context.Users.Count(X => X.UserName == userName && X.PassWord == Pass );
            if(result >0)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
       

    }
}