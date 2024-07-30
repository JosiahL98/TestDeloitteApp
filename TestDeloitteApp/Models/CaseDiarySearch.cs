using Microsoft.AspNetCore.Mvc;

using System.ComponentModel.DataAnnotations;

namespace TestDeloitteApp.Models
{
    public class CaseDiarySearch
    {
        [ Required, Display(Name = "Case Id")]
        public string CaseId { get; set; }
        [ Display(Name = "Function Type")]
        public string? FunctionType { get; set; }
        [ Display(Name = "Sub Function Type")]
        public string? SubFunctionType { get; set; }
        [ Required]
        public string Open { get; set; }
        [ Required, Display(Name = "Primary Activity Type")]
        public string Prim { get; set; }
        [ Display(Name = "Start Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
    }
}
