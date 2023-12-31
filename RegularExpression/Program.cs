﻿using System.Text.RegularExpressions;

Console.WriteLine("welcome to the regular expression program");
Console.WriteLine("1,checking userfirstname\n2.checking userLatname\n3.checking useremailId\n4.checking userPhoneNumber\n5.checking userPassword\n6. checking user Password withAtleast one capital letter\n7. checking user Password withAtleast one Number\n8. checking user Password withExact one special character");
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
                Console.WriteLine("{0} invalid of user firstname", input);
            }

        }
        break;
    case 2:
        Console.WriteLine("checking Last name of user ");
        string p = @"^[A-Z][a-zA-Z]{2,}$";
        string[] LastName = { "Mudigonda", "mudigonda", "Ponnaganti", "ponnaganti" };
        foreach (string input in LastName)
        {
            if (Regex.IsMatch(input, p))


            {
                Console.WriteLine("{0} is a valid  of userLasstname", input);
            }
            else
            {
                Console.WriteLine("{0} invalid of user Lasttname", input);
            }

        }
        break;
    case 3:
        Console.WriteLine("checking valid email");
        string mail = @"^[a-zA-Z0-9]([._%+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+(\.[a-zA-Z]{2,}){1,2}$";
        string[] email = { "jayaprakashjp187@gmail.com", "jp.88@gmail.com", "jp@gmail.com", "jp.com" };
        foreach (string input in email)
        {
            if (Regex.IsMatch(input, mail))


            {
                Console.WriteLine("{0} is a valid  of user emailId", input);
            }
            else
            {
                Console.WriteLine("{0} invalid of user emailId", input);
            }

        }
        break;
    case 4:
        Console.WriteLine("checking Last name of user ");
        string phoneNumber = @"^91[ ][0-9]{10}$";
        string[] phone = { "91 9640935321", "91 7337545935", "916361419518", "91 9398039076", "916303424324" };
        foreach (string input in phone)
        {
            if (Regex.IsMatch(input, phoneNumber))


            {
                Console.WriteLine("{0} is a valid  of user PhoneNumber", input);
            }
            else
            {
                Console.WriteLine("{0} invalid of user PhoneNumber", input);
            }

        }
        break;
    case 5:
        Console.WriteLine("checking password");
        string[] password = { "jayaprakash", "Jayaprakash", "jayp" };
        string pass = "^[a-zA-Z]{8,}$";
        foreach (string input in password)
        {
            if (Regex.IsMatch(input, pass))


            {
                Console.WriteLine("{0} is a valid  of user password", input);
            }
            else
            {
                Console.WriteLine("{0} invalid of user password", input);
            }



        }
        break;
        case 6:
        Console.WriteLine("setting a password with atleast one capital");

        string[] passWord = { "jayaprakash", "JayaPrakash", "jayp","Jaya","JAYAPRAk","Jayapra@" };
     
        string passInput = @"^(?=.*[A-Z])[A-Za-z]{8,}$";

        foreach (string input in passWord)
        {
            if (Regex.IsMatch(input, passInput))


            {
                Console.WriteLine("{0} is a valid  of user password", input);
            }
            else
            {
                Console.WriteLine("{0} invalid of user password", input);
            }



        }
        break;
        case 7:
        Console.WriteLine("setting a password with atleast one number");
        string a = @"^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}$";
        string[] passwordWithNum = { "Jaya1prakash#", "jayaprakash", "Jayaprakash", "Jayaprakash1524" };
        foreach (string input in passwordWithNum)
        {
            if (Regex.IsMatch(input, a))


            {
                Console.WriteLine("{0} is a valid  of user password", input);
            }
            else
            {
                Console.WriteLine("{0} invalid of user password", input);
            }



        }

        break;
        case 8:
        Console.WriteLine("setting a password with exact one special character provided");
        string b = "^(?=.*[A-Z])(?=.*[@#$%^&+=!])(?!.*[@#$%^&+=!].*[@#$%^&+=!])[A-Za-z0-9@#$%^&+=!]{8,}$";
        string[] passwordWithExactOneSpecialChar = { "Jaya1praka@sh", "jayaprakash", "Jayaprakash", "Jayaprakash1524", "Jayaprakash143@#"};
        foreach (string input in passwordWithExactOneSpecialChar)
        {
            if (Regex.IsMatch(input, b))


            {
                Console.WriteLine("{0} is a valid  of user password", input);
            }
            else
            {
                Console.WriteLine("{0} invalid of user password", input);
            }
            
        }
        break;
}
