using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationFormBuilder.Products
{
  public class UserForm
  {
    public string Header { get; set; }
    public string NameField { get; set; }
    public string EmailField { get; set; }
    public string PasswordField { get; set; }
    public string AdditionalFields { get; set; }

    public void DisplayForm()
    {
      Console.WriteLine(Header);
      Console.WriteLine(NameField);
      Console.WriteLine(EmailField);
      Console.WriteLine(PasswordField);

      if (!string.IsNullOrEmpty(AdditionalFields))
      {
        Console.WriteLine(AdditionalFields);
      }
    }
  }
}
