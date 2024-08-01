using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace BookApp.CustomValidations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class CustomFileExtensionValidation
    : ValidationAttribute, IClientModelValidator
    {
        public string Extensions { get; set; }
        public CustomFileExtensionValidation() {
            ErrorMessage = "Invalid file extension(s)";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return true;
            if (value is IFormFile file)
                return ValidateFile(file);

            if (value is List<IFormFile> files)
                return ValidateFiles(files);
            return false;
        }
        private bool ValidateFile(IFormFile file)
        {
            if (file == null || string.IsNullOrEmpty(file.FileName))
            {
                // File is null or empty, return false indicating validation failure
                return false;
            }

            if (!string.IsNullOrEmpty(Extensions))
            {
                //check if the file type uploaded matches any of the extensions defined
                var allowedExtensions = Extensions.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                        .Select(ext => ext.Trim())
                                                        .ToList();

                var fileName = file.FileName;

                var isValid = allowedExtensions.Any(ext => fileName.EndsWith(ext, StringComparison.OrdinalIgnoreCase));

                return isValid;
            }
            // File is valid
            return true;
        }
        private bool ValidateFiles(List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
            {
                // Value is null or empty, return false indicating validation failure
                return false;
            }

            if (!string.IsNullOrEmpty(Extensions))
            {
                var allowedExtensions = Extensions.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                     .Select(ext => ext.Trim().ToLower())
                                                     .ToList();

                bool isValid = files.All(file =>
                {
                    if (file == null ||
                    string.IsNullOrEmpty(file.FileName))
                    {
                        // File is null or empty, return false indicating validation failure
                        return false;
                    }
                    var fileName = file.FileName.ToLower();

                    return allowedExtensions.Any(ext => fileName.EndsWith(ext));
                });

                return isValid;
            }
            // All files are valid
            return true;
        }
       

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-mycustomvalidation", ErrorMessage);
        }
    }
}