using System.Collections.Generic;
using HelpApp.Domain.Validation;


namespace HelpApp.Domain.Entities
{
    public class Category
    {
        #region atibutos
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region constructors
        public Category(string name)
        {
            ValidationDomain(name);
        }
        public ICollection<Product> Products { get; set; }
        #endregion
        #region Validation
        private void ValidationDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name name is required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name, too short, minum 3 characters.");

            Name = name;
        }
        #endregion
    }
}