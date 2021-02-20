namespace Sefd.Phonebook.Entities.Concretes.Entities
{
    public class ContactInformation : BaseEntity
    {
        #region Properties
        public int ContactId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual Contact Contact { get; set; }
        #endregion
    }
}
