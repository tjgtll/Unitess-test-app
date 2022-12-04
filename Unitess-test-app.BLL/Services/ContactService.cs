using System;
using System.Collections.Generic;
using System.Linq;
using Unitess_test_app.BLL.Services.IServices;
using Unitess_test_app.DAL.Interface;
using Unitess_test_app.DAL.Model;
#pragma warning disable S3928 
namespace Unitess_test_app.BLL.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepo _contactRepo;
        public ContactService(IContactRepo contactRepository)
        {
            _contactRepo = contactRepository;
        }

        public IEnumerable<Contact> GetContactsRange(int start, int end)
        {
            if( start < 0 || end < 0)
            {
                throw new ArgumentOutOfRangeException($"parametr cannot be less 0");
            }
           
            var result = _contactRepo.Get();

            if (result.Count() <= end - 1 || result.Count() <= start - 1)
            {

                throw new ArgumentOutOfRangeException($"parametr cant be more lenght result");
            }

            if (start > end)
            {
                (start, end) = (end, start);
                result = result.ToList().GetRange(start, end - start + 1);
                return result.Reverse();
            }

            return result.ToList().GetRange(start, end - start + 1);
        }
    }
}
