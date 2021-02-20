using System.Collections.Generic;

namespace Sefd.Phonebook.Entities.Concretes.Entities
{
    public class Contact : BaseEntity
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }

        public virtual IList<ContactInformation> ContactInformations { get; set; }
        #endregion
    }
}
