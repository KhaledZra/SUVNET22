/* Kod skriven av Khaled Zraiqi

 -Projekt förklaring-

Projektet handlar om att bygga en adressbok med C# .Net

 -Projekt mål-

Lägga till namn till adressboken
Visa alla namn som finns i adressboken
rensa adressboken så att den blir tom
det ska gå att avsluta programmet genom att exempelvis trycka på Q

Visa statistik på totalt antal tecken i adressboken
Användargränssnitt ska vara prydligt och lättanvänt. Inte behöver trycka enter
använd fina färger
adressboken ska kunna visa statistik på totala antal namn
felhantering. t.ex se till att de inte går att mata in tomma namn

 -Projekt regler-

OBS Inga Listor eller klasser!
*/

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // _- Local Variables -_
            string sInput = string.Empty;
            bool bAlive = true;
            int iAmountOfNames = 0;
            string[] sArrayAddressBookNames = new string[iAmountOfNames]; // Name Database

            // Present clean start to program
            Console.Clear();
            // Main Loop
            while (bAlive)
            {
                ShowMainMenu();
                // Converts from ConsoleKeyInfo -> Char -> string and lowers if capital
                sInput = Convert.ToString(Console.ReadKey().KeyChar).ToLower();
                Console.Clear();

                switch (sInput)
                {
                    case "1":
                        SetGreen("Correct input");
                        Console.WriteLine(": Option 1 selected!");
                        sArrayAddressBookNames = AddNameToDB(sArrayAddressBookNames);
                        break;

                    case "2":
                        SetGreen("Correct input");
                        Console.WriteLine(": Option 2 selected!");
                        ShowNames(sArrayAddressBookNames);
                        break;

                    case "3":
                        SetGreen("Correct input");
                        Console.WriteLine(": Option 3 selected!");
                        sArrayAddressBookNames = ResetArray(sArrayAddressBookNames);
                        break;

                    case "4":
                        SetGreen("Correct input");
                        Console.WriteLine(": Option 4 selected!");
                        ShowStats(sArrayAddressBookNames);
                        break;

                    case "q":
                        SetGreen("Correct input");
                        Console.WriteLine(": Thanks for using Khaled's Address book!");
                        SetYellow("Press any key to close");
                        Console.ReadKey();
                        bAlive = false; // Loop will stop
                        break;

                    default:
                        SetRed("ERROR");
                        Console.WriteLine($": ({sInput}), is a unrecognized input!");
                        break;
                }
            }

        }

        // Main Methods
        #region Main menu methods
        static void ShowMainMenu()
        {
            Console.WriteLine(" ----------------");
            SetBlue("   Address book  \n");
            Console.WriteLine(" ----------------");
            Console.WriteLine("|1| Add name     |");
            Console.WriteLine("|2| Show names   |");
            Console.WriteLine("|3| Clear names  |");
            Console.WriteLine("|4| Show stats   |");
            Console.WriteLine("|Q| Exit program |");
            Console.WriteLine(" ----------------");
            Console.Write("Input: ");
        } 
        #endregion

        // Case 1
        #region Add name methods
        static string[] AddNameToDB(string[] sArrayAdressBookDB)
        {
            sArrayAdressBookDB = IncreaseArraySize(sArrayAdressBookDB); // makes space for new name
            sArrayAdressBookDB[sArrayAdressBookDB.Length - 1] = NameChecker(); // enters new name at new spot (which is last)

            return sArrayAdressBookDB;
        }

        static string[] IncreaseArraySize(string[] sArrayAdressBookDB)
        {
            string[] sArrTemp = new string[sArrayAdressBookDB.Length + 1];

            if (sArrayAdressBookDB.Length == 0) // if the array is empty
            {
                sArrayAdressBookDB = new string[1]; // there is no need to save anything so we just recreate with new size

                return sArrayAdressBookDB;
            }
            else
            {
                for (int i = 0; i < sArrayAdressBookDB.Length; i++) // copies names to temp
                {
                    sArrTemp[i] = sArrayAdressBookDB[i];
                }

                sArrayAdressBookDB = new string[sArrTemp.Length]; // reset array to new size
                sArrayAdressBookDB = sArrTemp; // sends over copied names

                return sArrayAdressBookDB;
            }
        }

        static string NameChecker()
        {
            // _- Local Variables -_
            bool bFailed;
            int iBackspaceCounter;
            string? sReason;
            string? sNameToCheck;

            while (true) // Only breaks when correct name expectation is met
            {
                // Reset values/Initialize
                bFailed = false;
                iBackspaceCounter = 0;
                sReason = string.Empty;
                sNameToCheck = string.Empty;

                Console.WriteLine("Accepted examples: bob, bob bobsson");
                Console.Write("Enter name: ");
                sNameToCheck = Console.ReadLine().ToLower();
                Console.Clear();

                if (string.IsNullOrEmpty(sNameToCheck))
                {
                    sReason = "You pressed enter without typing a name";
                    bFailed = true;
                }
                else
                {
                    for (int i = 0; i < sNameToCheck.Length; i++) // Loop through the entered string
                    {
                        if (sNameToCheck.Length <= 2)
                        {
                            sReason = "Name was too short!";
                            bFailed = true;
                            break;
                        }
                        else if (!char.IsLetter(sNameToCheck[i]) && !(sNameToCheck[i] == 32)) // Checks if letter AND does not check if it's a space
                        {
                            sReason = "Name does not only contain letters!";
                            bFailed = true;
                            break;
                        }
                        else if (sNameToCheck[i] == 32) // Checks if it's space.
                        {
                            if (sNameToCheck[0] == 32 || sNameToCheck[sNameToCheck.Length - 1] == 32) // checks if user is starting/ending with space
                            {
                                sReason = "Name can't start/end with space!";
                                bFailed = true;
                                break;
                            }

                            iBackspaceCounter++;
                            if (iBackspaceCounter == 2) // Checks if more than two spaces are entered with the name 
                            {
                                sReason = "Name has too many spaces!";
                                bFailed = true;
                                break;
                            }
                        }
                    }

                    if (iBackspaceCounter == 1) // If user decided to enter first and lastname
                    {
                        // _- Temp variable -_
                        string[] iArrayTemp = sNameToCheck.Split(" ");

                        if (iArrayTemp[0].Length == 1)
                        {
                            if (iArrayTemp[1].Length == 1)
                            {
                                sReason = "First and last name was too short";
                            }
                            else
                            {
                                sReason = "First name was too short";
                            }
                            bFailed = true;
                        }
                        else if (iArrayTemp[1].Length == 1)
                        {
                            sReason = "Second name was too short";
                            bFailed = true;
                        }
                    }
                }

                if (bFailed == false) // User entered expected name
                {
                    SetGreen("Success! ");
                    Console.WriteLine($"The name: '{sNameToCheck}' was added!");
                    return sNameToCheck;
                }
                else // User did not enter expected name
                {
                    Console.Clear();
                    SetRed("Failed! ");
                    Console.WriteLine(sReason);
                    Console.WriteLine($"({sNameToCheck}) is not a valid name, try again!");
                }
            }
        } 
        #endregion

        // Case 2
        #region Show Names methods
        static void ShowNames(string[] sArrayAdressBookDB)
        {
            if (sArrayAdressBookDB.Length == 0) // If empty
            {
                Console.WriteLine("Address book is empty...");
            }
            else // if not empty
            {
                for (int i = 0; i < sArrayAdressBookDB.Length; i++) // loops through array
                {
                    Console.WriteLine($"Location {i + 1}: {sArrayAdressBookDB[i]}");
                }
            }
        } 
        #endregion

        // Case 3
        #region Reset Array methods
        static string[] ResetArray(string[] sArrayAdressBookDB)
        {
            // _- Local Variables -_
            string? sInput = string.Empty;

            if (sArrayAdressBookDB.Length == 0) // If empty
            {
                Console.WriteLine("Nothing to reset, Address book is already empty..");
                return sArrayAdressBookDB;
            }
            else
            {
                while (true)
                {
                    SetRed("DELETE ALL?\n");
                    SetYellow("Confirm by pressing 'y' (yes) or 'n' (No)");
                    sInput = Convert.ToString(Console.ReadKey().KeyChar).ToLower();
                    Console.Clear();

                    if (sInput == "y") // if user selects y
                    {
                        sArrayAdressBookDB = new string[0];
                        SetGreen("Success! ");
                        Console.WriteLine("Address book was reset!");
                        return sArrayAdressBookDB;
                    }
                    else if (sInput == "n") // if user selects n
                    {
                        Console.WriteLine("Returning back to main menu, Address book was not reset.");
                        return sArrayAdressBookDB;
                    }
                    else // If user enters unexpected input
                    {
                        SetRed("ERROR");
                        Console.WriteLine($": Input {sInput} is not valid, try again!");
                    }
                }
            }
        } 
        #endregion

        // Case 4
        #region Show Stats methods
        static void ShowStats(string[] sArrayAdressBookDB)
        {
            // _- Local Variables -_
            int iLetters = 0;
            string[] sArrTemp = new string[0];

            Console.WriteLine($"Total amount of people stored: {sArrayAdressBookDB.Length}");

            if (sArrayAdressBookDB.Length == 0)
            {
                Console.WriteLine($"Total amount of letters stored: 0");
            }
            else
            {
                for (int i = 0; i < sArrayAdressBookDB.Length; i++)
                {
                    // Reason for split is to avoid counting space between names (if there's a first and last name)
                    sArrTemp = sArrayAdressBookDB[i].Split(" ");

                    if (sArrTemp.Length == 1) // Checks if there is a first name
                    {
                        for (int j = 0; j < sArrTemp[0].Length; j++)
                        {
                            iLetters++;
                        }
                    }
                    else // if there's a first and last name
                    {
                        for (int j = 0; j < sArrTemp[0].Length; j++) // First name counter
                        {
                            iLetters++;
                        }
                        for (int j = 0; j < sArrTemp[1].Length; j++) // Last name counter
                        {
                            iLetters++;
                        }
                    }
                }
                Console.WriteLine($"Total amount of letters stored: {iLetters}");
            }
        } 
        #endregion

        // Color handler methods, turns given text to following color
        #region Color methods
        static void SetRed(string? sText)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(sText);
            Console.ResetColor();
        }
        static void SetGreen(string? sText)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(sText);
            Console.ResetColor();
        }
        static void SetBlue(string? sText)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(sText);
            Console.ResetColor();
        }
        static void SetYellow(string? sText)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(sText);
            Console.ResetColor();
        } 
        #endregion
    }
}