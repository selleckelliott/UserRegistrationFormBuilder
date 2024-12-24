using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationFormBuilder.Builders;
using UserRegistrationFormBuilder.Products;

namespace UserRegistrationFormBuilder
{
  public class FormDirector
  {
    private readonly IUserFormBuilder _formBuilder;

    public FormDirector(IUserFormBuilder formBuilder)
    {
      _formBuilder = formBuilder;
    }
    public void ConstructForm()
    {
      _formBuilder.BuildHeader();
      _formBuilder.BuildNameField();
      _formBuilder.BuildEmailField();
      _formBuilder.BuildPasswordField();
      _formBuilder.BuildAdditionalFields();
    }
    public UserForm GetForm() => _formBuilder.GetForm();
  }
}
