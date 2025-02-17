﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Code).NotEmpty();
            RuleFor(u => u.Name).NotEmpty();
            RuleFor(u => u.Pass).NotEmpty();
            RuleFor(u => u.Filter).NotEmpty();
        }
    }
}
