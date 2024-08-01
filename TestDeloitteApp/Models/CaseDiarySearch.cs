using BookApp.CustomValidations;
using Microsoft.AspNetCore.Mvc;

using System.ComponentModel.DataAnnotations;
using TestDeloitteApp.Validators;

namespace TestDeloitteApp.Models
{
    public class CaseDiarySearch
    {
        [Display(Name = "Case Id"), CustomStringLengthAttribute(5, 10, ErrorMessage = "The field must be between 5 and 10 characters.")]
        public string CaseId { get; set; }

        [ Display(Name = "Function Type")]
        public string? FunctionType { get; set; }
        [ Display(Name = "Sub Function Type")]
        public string? SubFunctionType { get; set; }
  

        public string Open { get; set; }
        [Required,  Display(Name = "Primary Activity Type")]
        public string Prim { get; set; }
        [ Display(Name = "Start Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
    }
}
