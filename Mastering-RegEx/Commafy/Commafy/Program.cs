/* This example is modified from the examples in O'Reilly's Mastering Regular Expressions
*/

// See https://aka.ms/new-console-template for more information
using System;
// Import the RegEx module
using System.Text.RegularExpressions;

// Initialize our string to blank
string strNumber = "";

Console.WriteLine("Please enter a number greater than 999.  The larger the number, the better: ");

// Get the input from the user
strNumber = Console.ReadLine();

/* RegEx:
    @"" - C# - Designates this as a RegEx pattern
    ^   - From the beginning of the string
    \d{4,} - Match 4 or more digits
    $   - To the end of the string (ensuring there are no other characters)
*/
if(Regex.IsMatch(strNumber, @"^\d{4,}$")) {
    // Insert the commas into the number
    /* RegEx:
        ?<= - Positive look behind (can we match this pattern before our current position)
        \d  - Match exactly 1 digit
        ?=  - Positive look ahead (can we match this pattern after our current position)
        ()  - Subexpression group
        (?: - Do NOT assign this group to a variabel (TODO:  Verify if these backreferences are assigned to variables as in Perl)
        \d{3} - Match exactly 3 digits
        ?!  - Negative look ahead (does the pattern after our current position no match)
    */
    strNumber = Regex.Replace(strNumber, @"(?<=\d)(?=(?:\d{3})+(?!\d))", ",");

    Console.WriteLine(strNumber);
} else {
    Console.WriteLine("Please enter at least 4 ditits!");
}
