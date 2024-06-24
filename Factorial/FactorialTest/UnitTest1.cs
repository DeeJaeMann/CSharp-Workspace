using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factorial;

namespace Factorial.FactorialTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestPromptString()
    {
        // Tests that we receive a prompt string
        using (StringWriter stringWriter = new StringWriter())
        {
            // Redirect console output to stringWriter
            Console.SetOut(stringWriter);

            using (StringReader stringReader = new StringReader(string.Format($"2")))
            {
                // Set the input to the stringReader value
                Console.SetIn(stringReader);
                // Run the main program
                Program.Main([]);

                string expected = string.Format("Please enter a number: {0}You entered 2{0}Factorial: 2{0}", Environment.NewLine);

                Assert.AreEqual<string>(expected, stringWriter.ToString());
            }
        }
    }
}