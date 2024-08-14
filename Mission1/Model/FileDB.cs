using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mission1.Model
{
    public class FileDB
    {
        public static Dictionary<string, Customer> LoadCustomer()
        {
            // Ensure the file exists before attempting to read
            if (!File.Exists("Customer.txt"))
            {
                return new Dictionary<string, Customer>();
            }

            using (var reader = new StreamReader(new FileStream("Customer.txt", FileMode.OpenOrCreate), Encoding.Default))
            {
                string jsonStr = reader.ReadToEnd();

                if (!string.IsNullOrWhiteSpace(jsonStr))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<Dictionary<string, Customer>>(jsonStr);
                    }
                    catch (JsonReaderException ex)
                    {
                        // Handle JSON reading errors
                        Console.WriteLine($"Error reading JSON data: {ex.Message}");
                        return new Dictionary<string, Customer>(); // Return an empty dictionary on error
                    }
                }
                else
                {
                    return new Dictionary<string, Customer>();
                }
            }
        }

        public static Rule LoadRule()
        {
            if (!File.Exists("Rule.txt"))
            {
                return new Rule { MinimumUsablePoint = 1000 }; // Return default Rule if file doesn't exist
            }

            using (var reader = new StreamReader(new FileStream("Rule.txt", FileMode.OpenOrCreate), Encoding.Default))
            {
                string jsonStr = reader.ReadToEnd();

                if (!string.IsNullOrEmpty(jsonStr))
                {
                    try
                    {
                        return JsonConvert.DeserializeObject<Rule>(jsonStr);
                    }
                    catch (JsonReaderException ex)
                    {
                        // Handle JSON reading errors
                        Console.WriteLine($"Error reading JSON data: {ex.Message}");
                        return new Rule { MinimumUsablePoint = 1000 }; // Return default Rule on error
                    }
                }
                else
                {
                    return new Rule { MinimumUsablePoint = 1000 }; // Return default Rule if file is empty
                }
            }
        }

        public static void SaveCustomer(Dictionary<string, Customer> customers)
        {
            string jsonStr = JsonConvert.SerializeObject(customers, Formatting.Indented); // Formatting for readability

            // Open the file in Create mode to overwrite the content
            using (var writer = new StreamWriter(new FileStream("Customer.txt", FileMode.Create), Encoding.Default))
            {
                writer.Write(jsonStr);
            }
        }
    }
}
