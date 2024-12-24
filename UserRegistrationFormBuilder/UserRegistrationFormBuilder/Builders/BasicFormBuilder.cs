using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationFormBuilder.Products;

namespace UserRegistrationFormBuilder.Builders
{
  public class BasicFormBuilder : IUserFormBuilder
  {
    private UserForm _form = new UserForm();

    public void BuildHeader() => _form.Header = "Basic Registration Form";
    public void BuildNameField() => _form.NameField = "Name: [ ]";
    public void BuildEmailField() => _form.EmailField = "Email: [ ]";
    public void BuildPasswordField() => _form.PasswordField = "Password: [ ]";
    public void BuildAdditionalFields() => _form.AdditionalFields = string.Empty;

    public UserForm GetForm() => _form;
  }
}
