using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Program
    {
        static void Main(string[] args)
        {
            {
            RunAutomatedTests();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        }

        public static void RunAutomatedTests()
        {
            TestUserScenario();
        }

        public static void TestUserScenario()
        {
            Console.WriteLine("Running automated tests...\n");

            // Given: The user is a retail user and is logged in
            Console.WriteLine("Given: The user is a retail user and is logged in.");

            // Given: The user is on the PLP - Cane-line Sense Woven 3-Seater Sofa
            Console.WriteLine("Given: The user is on the PLP - Cane-line Sense Woven 3-Seater Sofa.");

            // Simulate clicking on the product image
            string result = ClickOnProductImage();

            // Expected behavior
            string expectedMessage = "We cannot find the page you're looking for.";
            
            // Check the result
            if (result == expectedMessage)
            {
                Console.WriteLine("Test Passed: The correct error message was displayed.");
            }
            else
            {
                Console.WriteLine("Test Failed: Unexpected result. Actual message: " + result);
            }
        }

        public static string ClickOnProductImage()
        {
            // Simulate clicking on the product image
            Console.WriteLine("And: The user clicks on the product image.");
            
            // Simulate redirection to an error page
            return "We cannot find the page you're looking for.";
        }
    }
}

        
    

