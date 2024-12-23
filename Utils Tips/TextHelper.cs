// This helper class provides a static method for text manipulation.

// Currently, it includes functionality to capitalize the first letter of a string, ensuring the rest of the string is in lowercase. This method is designed to assist with common text formatting tasks in an application, ensuring consistency and efficiency.

public static class TextHelper
{
  public static string CapitalizeFirstLetter(string input)
  {
      return char.ToUpper(input[0]) + input.Substring(1).ToLower();

    /*
      Usage:
      
      string tagValue = "teST";
      tagValue = CapitalizeFirstLetter(tagValue);
      Console.WriteLine(tagValue); // Output: Test
    */
  }
}
