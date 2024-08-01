using FluentValidation;
using System;
using TestDeloitteApp.Models;

namespace TestDeloitteApp.Validators
{
    public class CaseDiarySearchValidator : AbstractValidator<CaseDiarySearch>
    {
        public CaseDiarySearchValidator()
        {
            RuleFor(x => x.CaseId).NotNull();
            
        }
    }
}