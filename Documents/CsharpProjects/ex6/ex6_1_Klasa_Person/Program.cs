using System;
using System.Linq;
namespace MyProg 
{
  // STUDENT_ANSWER
    public class Person
    {
        private string _familyName;
        private string _firstName;
        private DateTime _birthday;
        public string FamilyName { 
          
          get => _familyName; 
          set{
           value = value?.Trim();
            if (value == null)
                throw new ArgumentException("Incorrect data for FamilyName");
            if (string.IsNullOrEmpty(value) || !value.All(c => char.IsLetter(c) || c == '-'))
                throw new ArgumentException("Incorrect data for FamilyName");
            
            var parts = value.Split('-');
             if (parts.Length > 2 || parts.Any(part => part.Length < 2 || !char.IsUpper(part[0]) || part.Substring(1).Any(c => !char.IsLower(c))))
                throw new ArgumentException("Incorrect data for FamilyName");

            _familyName = FormatName(value);
          }
          
        }
        public string FirstName { 
        get => _firstName;
        set
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value) || value.Length < 2 || !char.IsUpper(value[0]) || value.Substring(1).Any(c => !char.IsLower(c)))
              throw new ArgumentException("Incorrect data for FirstName");

            _firstName = FormatName(value);
        }
        }
        
        public DateTime Birthday { 
        get => _birthday;
        set
        {
          if(value > DateTime.Now){
            throw new ArgumentException("Incorrect data for Birthday");
          }
          _birthday = value;
        }
        }
        public Person(string familyName, string firstName, DateTime birthday)
        {
            FamilyName = familyName;
            FirstName = firstName;
            Birthday = birthday;
        }
        private string FormatName(string name)
        {
          var parts = name.Split('-');
          return string.Join("-", parts.Select(part => char.ToUpper(part[0]) + part.Substring(1).ToLower()));
        }
        public override string ToString()
        {
            return $"{FirstName} {FamilyName} ({Birthday:yyyy-MM-dd})";
        }
    }
  public class Program
  {
    public static void Main(string[] args) 
    {
      // TEST.testcode
      Person p5 = new Person("  Aaa  ", "Bbb", new DateTime(2000, 1, 1));
      Console.WriteLine( p5.FamilyName );
    }
  }
}