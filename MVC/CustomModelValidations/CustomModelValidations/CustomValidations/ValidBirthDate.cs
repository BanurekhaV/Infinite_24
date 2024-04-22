using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CustomModelValidations.Models;

namespace CustomModelValidations.CustomValidations
{
    //custom class for DOB validation
    public sealed class ValidBirthDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime entered_dob = Convert.ToDateTime(value);
            DateTime mindt = Convert.ToDateTime("01/01/1995");
            DateTime maxdt = Convert.ToDateTime("25/01/2002");

            if(entered_dob >= mindt && entered_dob <= maxdt )          
                return ValidationResult.Success;
                else
                    return new ValidationResult(ErrorMessage);            
        }
    }

    public class GenderValidate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToString(value) == "M" || Convert.ToString(value) == "F")
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }
}