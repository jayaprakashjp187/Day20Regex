using System.Text.RegularExpressions;

Console.WriteLine("welcome to the regular expression program");
Console.WriteLine("1,checking userfirstname\n2.");
Console.WriteLine("choose what program u want");
int choose = Convert.ToInt32(Console.ReadLine());
switch (choose)
{
    case 1:
        Console.WriteLine("first name of user");
        string pattern = @"^[A-Z][a-zA-Z]{2,}$";
        string[] firstName = { "Jayaprakash", "jayy", "jaypee", "Jaya" };
        foreach (string input in firstName)
        {
            if (Regex.IsMatch(input, pattern))


            {
                Console.WriteLine("{0} is a valid  of userfirstname", input);
            }
            else
            {
                Console.WriteLine("{0} invalid of user firstname",input);
            }

        }
        break;
        case 2:
        Console.WriteLine("");
        break;

}
