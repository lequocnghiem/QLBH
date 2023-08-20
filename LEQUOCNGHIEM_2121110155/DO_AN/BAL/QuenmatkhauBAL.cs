using DO_AN.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN.BAL
{
    internal class QuenmatkhauBAL
    {
        QuenmatkhauDAL dal = new QuenmatkhauDAL();

        public bool IsEmail(string email)
        {
            return dal.IsEmailExists(email);
        }
    }
}
