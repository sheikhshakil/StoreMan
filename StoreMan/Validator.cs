using System;

namespace StoreMan
{
    class Validator
    {
        public static bool validate_pName(string input)
        {
            if (input.Length >= 3)
                return true;
            else
            {
                MessageBoxer.showErrorMsg("Product name should be minimum 3 to 1000 characters long!");
                return false;
            }
        }
        public static bool validate_quantity(string input)
        {
            if (input.Length > 0)
            {
                try
                {
                    Convert.ToDouble(input);
                    return true;
                }
                catch
                {
                    MessageBoxer.showErrorMsg("Quantity should be a number value!");
                    return false;
                }
            }
            else
            {
                MessageBoxer.showErrorMsg("Quantity cannot be blank!");
                return false;
            }
        }

        public static bool validate_ppu(string input)
        {
            if (input.Length > 0)
            {
                try
                {
                    Convert.ToDouble(input);
                    return true;
                }
                catch
                {
                    MessageBoxer.showErrorMsg("Price per unit should be a number value!");
                    return false;
                }
            }
            else
            {
                MessageBoxer.showErrorMsg("Price per unit cannot be blank!");
                return false;
            }
        }

        public static bool validate_adminPass(string input)
        {
            if (input.Length >= 5)
            {
                return true;
            }
            else
            {
                MessageBoxer.showErrorMsg("New admin password should be minimum 5 characters long!");
                return false;
            }
        }
    }
}
