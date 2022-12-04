using System.Collections.Generic;
using Unitess_test_app.DAL.Model;

namespace Unitess_test_app.DAL.Interface
{
    public interface IContactRepo
    {
        IEnumerable<Contact> Get();
    }
}
