using System.Windows;
using WpfApp1.Model;

namespace WpfApp1.Helper
{
    public class FindRole
    {
       public int id;
        public FindRole(int id)
        {
            this.id = id;
        }
        public bool RolePredicate(Role role)
        {
            return role.Id == id;
        }
    }
}