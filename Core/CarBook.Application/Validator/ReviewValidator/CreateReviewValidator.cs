using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Validator.ReviewValidator
{
    public class CreateReviewValidator:AbstractValidator<CreateReviewCommand>
    {
        //rulefor ile commend değerleri için buradan kurallar yazabilirm
    }
}
