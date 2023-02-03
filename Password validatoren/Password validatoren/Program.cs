using System.Diagnostics.SymbolStore;

//The programs class
class Program
{
    //Main method to write out code
    static void Main(string[] args)
    {
        //Enters a password and save it in a varible
        Console.WriteLine("Enter password:");
        string rawPassword = Console.ReadLine();

        //Make the string varible to a char array
        char[] passwordArr = rawPassword.ToCharArray();

        //All the retuning values come in here from the merhods
        byte passwordLength = PasswordLength(passwordArr);
        bool upperAndLowercase = UpperAndLowercase(passwordArr);
        bool charactersAndDigit = CharactersAndDigit(passwordArr);
        bool specialCharacters = SpecialCharacters(passwordArr);
        bool sameNumbersOtrCharacters = SameNumbersOtrCharacters(passwordArr);
        bool fourNumbersInARow = FourNumbersInARow(passwordArr);

        //Switch that checks if the password is too long or too short
        switch (passwordLength)
        {
            case 1:
                Console.WriteLine("It's too short");
                break;

            case 2:
                Console.WriteLine("It's too long");
                break;
        }

        //Checks if the password is good
        if (passwordLength == 3 && upperAndLowercase && charactersAndDigit && specialCharacters)
        {
            //If the password is good then it checks if it's good but weak
            if (sameNumbersOtrCharacters || fourNumbersInARow)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Weak, but okay password");
            }

            //If it's not weak then it says "Good password"
            else
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Good password");
            }
        
        }

        //If it's not a good password then it writes "NOT GOOD!!"
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("NOT GOOO!!");
        }
    }

    //Method to check password length
    public static byte PasswordLength(char[] array)
    {
        //If the length is < 12 it returns 1 too the switch
        if (array.Length < 12)
        {
           return 1;

        }

        //If the length is > 64  it returns 2 too the switch
        else if (array.Length > 64)
        {
            return 2;
        }
        //If the length is between 12 - 64 then it returns 3
        return 3;
    }

    //Method to check if the have upper and lowercase
    public static bool UpperAndLowercase(char[] array)
    {
        //Varibles to count number of upper and lowercases
        byte uppercase = 0;
        byte lowercase = 0;

        //Loops through the array
        for (int i = 0; i < array.Length; i++)
        {
            //Checks for uppercase and add's 1 to the "uppercase varible"
            if (char.IsUpper(array[i]))
            {
                uppercase++;
            }

            //Checks for lowercase and add's 1 to the "lowercase varible"
            if (char.IsLower(array[i]))
            {
                lowercase++;
            }
        }

        //If upper and lowercase not is equal to 0 then it returns true
        if (uppercase != 0 && lowercase != 0)
        {
            return true;
        }
        //Else it returns false
        return false;
    }

    //Method tocheck if the password have characters/letters and digits
    public static bool CharactersAndDigit(char[] array)
    {
        //Varibles to count number of characters/letters and digits
        byte letter = 0;
        byte digit = 0;
        
        //Loops through the array
        for (int i = 0; i < array.Length; i++)
        {
            //Checks for digits and add's 1 to the "Digit varible"
            if (char.IsDigit(array[i]))
            {
                digit++;
            }

            //Checks for characters and add's 1 to the "letter varible"
            if (char.IsLetter(array[i]))
            {
                letter++;
            }
        }

        //If characters/letters and digits not is equal to 0 then it returns true
        if (digit != 0 || letter != 0)
        {
            return true;
        }
        //Else it returns false
        return false;
    }

    //Method to check if the password have special characters
    public static bool SpecialCharacters(char[] array)
    {
        //Varibles to count number of special characters
        byte spcChar = 0;

        //Loops through the array
        for (int i = 0; i < array.Length; i++)
        {
            //If it's not a character/letter or digit, it add's 1 to the "spcChar varible"
            if (!char.IsLetterOrDigit(array[i]))
            {
                spcChar++;
            }
        }

        //If spcChar > 0 then it returns true
        if (spcChar > 0)
        {
            return true;
        }
        //Else it returns false
        return false;
    }

    //Method to check if the password have 4 of the same numbers or letters in a row
    public static bool SameNumbersOtrCharacters(char[] array)
    {
        //Loops through the array
        for (int i = 0; i < array.Length-3; i++)
        {
            //Checks if the letter or number on i is egual to the 3 places in the array, and if it is it returns true
            if (array[i] == array[i+1] && array[i] == array[i + 2] && array[i] == array[i+3])
            {
                return true;
            }
        }
        //Else it returns false
        return false;
    }

    //Method to check if the password have four numbers in a row like (1, 2, 3, 4 or 5, 6, 7, 8)
    public static bool FourNumbersInARow(char[] array)
    {
        //Loops through the array
        for (int i = 0; i < array.Length - 3; i++)
        {
            //Checks if the 3 next numbers after "i" is 1, 2 and 3 greater than "i", if it is it returns true
            if (array[i+1]  == array[i] + 1 && array[i+2] == array[i] + 2 && array[i+3] == array[i] + 3)
            {
                return true;
            }
        }
        //Else it returns false
        return false;
    }
}