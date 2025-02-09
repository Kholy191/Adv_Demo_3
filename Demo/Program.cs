using System.Collections;

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

        Hashtable Note = new Hashtable()
        {
            ["Ahmed"] = 33,
            ["Mohamed"] = 66,
            ["Ali"] = 99,
        };

        foreach (DictionaryEntry item in Note)
        {
            Console.WriteLine($"Key {item.Key} Value = {item.Value}");
        }

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

        Dictionary<string, int> NoteG = new Dictionary<string, int>();
        NoteG.Add("aHMED", 31);
        NoteG.Add("ADAFA", 414);

        NoteG["Mahmoud"] = 31;

        foreach (var item in NoteG)
        {
            Console.WriteLine(item.Key, item.Value);
        }
        #endregion
    }
}

