using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Entity;

namespace WpfApp2.Service
{
    public class UserUpdateService
    {
        public void UpdateUser(User user, uint num)
        {
            user.Name = user.Name + num;
            user.Age = user.Age + num;
        }
        public User CreateUser(uint num)
        {
            return new User("Ivan" + num, 20 + num);
        }
    }
}
