using System.Collections.Generic;
using Unitess_test_app.DAL.Model;

namespace Unitess_test_app.BLL.Services.IServices
{
    public interface IContactService
    {
        IEnumerable<Contact> GetContactsRange(int start, int end);
    }
}
