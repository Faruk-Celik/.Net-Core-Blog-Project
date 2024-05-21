using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
        public WriterValidator()
        {
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer Name Can Not Be Empty");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Writer Mail Can Not Be Empty");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Writer Password Can Not Be Empty");
			//RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Writer Image Can Not Be Empty");

			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Writer Name Must Be At Least 2 Characters");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Writer Name Must Be At Most 50 Characters");
			//RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Please Enter A Valid Email Address");
			//RuleFor(x => x.WriterPassword).MinimumLength(5).WithMessage("Writer Password Must Be At Least 5 Characters");
			//RuleFor(x => x.WriterPassword).MaximumLength(20).WithMessage("Writer Password Must Be At Most 20 Characters");
			//RuleFor(p => p.WriterPassword).Matches(@"[A-Z]+").WithMessage("Password Contain At Least One UpperCase");
			//RuleFor(p => p.WriterPassword).Matches(@"[a-z]+").WithMessage("Password Contain At Least One UpperCase");
			//RuleFor(p => p.WriterPassword).Matches(@"[0-9]+").WithMessage("Password Contain At Least One Number");
			
			

		}
    }
}
