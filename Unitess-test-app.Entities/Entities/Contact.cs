using System;
                
namespace Unitess_test_app.Entity.Entities
{
    public class Contact : TEntity
    {
        public string Name { get; set; }

        public string MobilePhone { get; set; }

        public string JobTitle { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
