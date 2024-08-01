using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace TestDeloitteApp.Validators
{
   

    public class CustomStringLengthAttribute : ValidationAttribute, IClientModelValidator
    {
        private readonly int _minLength;
        private readonly int _maxLength;

        public CustomStringLengthAttribute(int minLength, int maxLength)
        {
            _minLength = minLength;
            _maxLength = maxLength;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var stringValue = value as string;

            if (stringValue != null && (stringValue.Length < _minLength || stringValue.Length > _maxLength))
            {
                return new ValidationResult(ErrorMessage ?? $"The field must be between {_minLength} and {_maxLength} characters.");
            }

            return ValidationResult.Success;
        }

       

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-customstringlength", ErrorMessage ?? $"The field must be between {_minLength} and {_maxLength} characters.");
            context.Attributes.Add("data-val-customstringlength-min", _minLength.ToString());
            context.Attributes.Add("data-val-customstringlength-max", _maxLength.ToString());
        }
    }

}
