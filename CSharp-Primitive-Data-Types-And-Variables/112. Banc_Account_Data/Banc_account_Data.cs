/* ==============================
 * Problem 12.	Bank Account Data
 * ==============================
 * A bank account has a holder name (first name, middle name and last name),
 * available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
 * Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */
using System;

class Bank_Account_Data
{
    static void Main()
    {
        // there is no requirement to print output, it is just to check.
        //bool PRINT = true;

        // Account Holder Personal Info
        string AccountHolderName = "Пешо";
        string AccountHolderMiddleName = "Джуджуфлечков";
        string AccountHolderLastName = "Каракацилев";
        // Banc Data
        string BankName = "Bank Of SoftUni";
        // Account Holder Contacted Products
        decimal CustomerBalance = 163212.1235m;
        string CustomerIBAN = "BG80BNBG96611020345678";
        string CustomerVISA = "4411 0011 2222 9006";
        string CustomerVISAElectron = "5411 0011 2222 9006";
        string CustomerMasterCard = "6411 0011 2222 9006";

        /*
        if ( PRINT )
        {
            // Let's check if everithing prins right:
            Console.WriteLine("Account Holder First Name: " + AccountHolderName);
            Console.WriteLine("Account Holder Middle Name: " + AccountHolderMiddleName);
            Console.WriteLine("Account Holder Last Name: " + AccountHolderLastName);
            Console.WriteLine("Bank Name: " + BankName);
            Console.WriteLine("Customer Balance: " + CustomerBalance);
            Console.WriteLine("Customer IBAN: " + CustomerIBAN);
            Console.WriteLine("Customer Visa: " + CustomerVISA);
            Console.WriteLine("Customer Visa Electron: " + CustomerVISAElectron);
            Console.WriteLine("Customer MasterCard: " + CustomerMasterCard);
        }
        */
        
    }
}