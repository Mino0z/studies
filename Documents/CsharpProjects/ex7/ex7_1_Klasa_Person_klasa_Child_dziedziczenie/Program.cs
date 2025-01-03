#nullable disable

using System;
using System.Linq;
namespace MyProg 
{
  // STUDENT_ANSWER
    public class Person
    {
        public string _familyName;
        public string _firstName;
        public int _age;
        public string FamilyName { get => _familyName;
            private set{
            value = value?.Trim();
            if (value == null)
                throw new ArgumentException("Wrong name!");
            _familyName = FormatName(value);
            }
            
        }
        public string FirstName { get => _firstName;
            private set{
            value = value?.Trim();
            if (value == null)
                throw new ArgumentException("Wrong name!");
            _firstName = FormatName(value);
            }
            
        }
        public virtual int Age {
            get => _age;
            set{
            if(value < 0)
                throw new ArgumentException("Age must be positive!");
            _age = value;
            }
        }
        public Person(string familyName, string firstName, int age)
        {
            FamilyName = FormatName(familyName);
            FirstName = FormatName(firstName);
            Age = age;
        }
        private string FormatName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Trim().Any(ch => !char.IsLetter(ch) && !char.IsWhiteSpace(ch)))
                throw new ArgumentException("Wrong name!");

            name = string.Join(" ", name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            name = string.Concat(name.Where(c => !char.IsWhiteSpace(c)));
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

            return name;
        }

        public void modifyFirstName(string newFirstName)
        {
            FirstName = newFirstName;
        }
        public void modifyFamilyName(string newFamilyName)
        {
            FamilyName = newFamilyName;
        }
        public void modifyAge(int newAge)
        {
            Age = newAge;
        }
        public override string ToString()
        {
            return $"{FirstName} {FamilyName} ({Age})";
        }
    }
    public class Child : Person{
        public readonly Person mother = null;
        public readonly Person father = null;

        
        public Child(string familyName, string firstName, int age, Person mother = null, Person father = null) : base(familyName, firstName, age)
        {
            if(age >15){
                throw new ArgumentException("Child’s age must be less than 15!");
            }
            this.mother = mother;
            this.father = father;
        }
        public override int Age {
        get {return base.Age;}
        set{
            if (value < 0){
                throw new ArgumentException("Age must be positive!");
            }
            if (value >15){
                throw new ArgumentException("Child’s age must be less than 15!");
            }
            base.Age = value;
            }
        }
        public override string ToString()
        {
            string result = $"{FirstName} {FamilyName} ({Age}) \n";

            if(mother == null){
                result += $"mother: No data\n";
            }
            else{
                result += $"mother: {mother.FirstName} {mother.FamilyName} ({mother.Age}) \n";
            }
            if(father == null){
                result += $"father: No data ";
            }
            else{
                result += $"father: {father.FirstName} {father.FamilyName} ({father.Age}) ";
            }    
            return result;        
        }

    }
  public class Program
  {
    public static void Main(string[] args) 
    {
      // TEST.testcode
        try
        {
            Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
            Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
            Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 10,
                                mother: m, father: o);
            Console.WriteLine(d);
        }
        catch( Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
  }
}