using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationFormBuilder.Products;

namespace UserRegistrationFormBuilder.Builders
{
  public interface IUserFormBuilder
  {
    void BuildHeader();
    void BuildNameField();
    void BuildEmailField();
    void BuildPasswordField();
    void BuildAdditionalFields();
    UserForm GetForm();
  }
}
