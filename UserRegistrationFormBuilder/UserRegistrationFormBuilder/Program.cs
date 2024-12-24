using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationFormBuilder.Builders;
using UserRegistrationFormBuilder.Products;

namespace UserRegistrationFormBuilder
{
  class Program
  {
    static void Main()
    {
      IUserFormBuilder basicBuilder = new BasicFormBuilder();
      FormDirector director = new FormDirector(basicBuilder);
      director.ConstructForm();
      UserForm basicForm = director.GetForm();
      Console.WriteLine("Basic Form:");
      basicForm.DisplayForm();

      Console.WriteLine();
      Console.WriteLine();

      IUserFormBuilder advancedBuilder = new AdvancedFormBuilder();
      director = new FormDirector(advancedBuilder);
      director.ConstructForm();
      UserForm advancedForm = director.GetForm();
      Console.WriteLine("Advanced Form:");
      advancedForm.DisplayForm();
    }
  }
}