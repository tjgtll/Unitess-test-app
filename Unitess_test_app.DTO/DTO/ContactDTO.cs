using System;
using System.Collections.Generic;
using System.Text;

namespace Unitess_test_app.DTO.DTO
{
    public class ContactDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MobilePhone { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
