using System.Collections;
using System.Runtime.InteropServices;

namespace Demo
{
    /// public class StringEqualityComparer : IEqualityComparer
    /// {
    ///     public new bool Equals(object? x, object? y)
    ///     {
    ///         string? StringX = x as string;
    ///         string? StringY = y as string;
    ///         return StringX?.ToLower().Equals(StringY?.ToLower()) ?? StringY is null? true: false;
    ///     }
    ///
    ///     public int GetHashCode(object obj)
    ///     {
    ///         string? StringX = obj as string; 
    ///         if (StringX != null)
    ///             return StringX.ToLower().GetHashCode();
    ///         else return 0;
    ///     }
}
internal class Program
{
    static void Main(string[] args)
    {
        #region HashTable

        //Hashtable Note = new Hashtable()
        //{
        //    ["Ahmed"] = 33,
        //    ["Mohamed"] = 66,
        //    ["Ali"] = 99,
        //};

        //foreach (DictionaryEntry item in Note)
        //{
        //    Console.WriteLine($"Key {item.Key} Value = {item.Value}");
        //}

        ///Add
        ///Note.Add("Ahmed", 124); // Exception //Unsafe
        ///if (!Note.ContainsKey("Ahmed")) // Safe
        ///{
        ///    Note.Add("Ahmed", 124);
        ///}

        ///GET
        /// Console.WriteLine($"Hash {Note["Ahmed"]}"); 

        #endregion

        #region Dictionary  

        //Dictionary<string, int> NoteG = new Dictionary<string, int>();
        //NoteG.Add("aHMED", 31);
        //NoteG.Add("ADAFA", 414);

        //NoteG["Mahmoud"] = 31;

        //foreach (var item in NoteG)
        //{
        //    Console.WriteLine(item.Key, item.Value);
        //}

        Dictionary<Employee, int> Emps = new Dictionary<Employee, int>();
        Emps.Add(new Employee(42, "Ahmed"), 10);
        Emps.Add(new Employee(41, "Mahmoud"), 10);



        Emps.Add(new Employee(41, "Mahmoud"), 10);

        foreach (var item in Emps)
        {
            Console.WriteLine(item.Key);
        }

        #endregion

    }

    public class Employee : IEquatable<Employee>
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public Employee(int Id, string name)
        {
            ID = Id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{ID} {Name}";
        }

        bool IEquatable<Employee>.Equals(Employee? other)
        {
            if (other is null)
                return false;
            if ((this.Name != null && other.Name != null))
                return this.ID.Equals(other.ID) && this.Name.Equals(other.Name);
            else if (this.Name != null && other.Name == null)
                return true;
            else if (this.Name == null && other.Name == null)
                return this.ID.Equals(other.ID);
            else
                return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID,Name);
        }
    }
}

