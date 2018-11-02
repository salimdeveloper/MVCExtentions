using System;
using System.ComponentModel.DataAnnotations;

namespace MVCExtentions.Infrastructure.Extentions.Validation
{
    public class BirthdateValidator : ValidationAttribute
    {
        public BirthdateValidator()
        {
            ErrorMessage = "Please enter a valid birth date. You must be 18 or older to apply.";
        }
        public override bool IsValid(object value)
        {
            DateTime enterDate;
            if (DateTime.TryParse(value.ToString(), out enterDate))
            {
                if (enterDate > DateTime.Now.AddYears(-18))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}