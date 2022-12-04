using System.Collections.Generic;
using Unitess_test_app.DAL.Interface;
using Unitess_test_app.DAL.Model;
using Dapper;
using Unitess_test_app.DAL.DataContext;

namespace Unitess_test_app.DAL.Repo
{
    public class ContactRepo : IContactRepo
    {
        public IEnumerable<Contact> Get()
        {
            using (var connection = DbContext.Connection())
            {
                return connection.Query<Contact>("select * from [Contact]");
            }
        }
    }
}
