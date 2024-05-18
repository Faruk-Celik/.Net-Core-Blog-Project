using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator :AbstractValidator<Blog>
    {
        public BlogValidator ()
        {

            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Title Can Not Be Empty");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog Content Can Not Be Empty");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Image Can Not Be Empty");
            RuleFor(x => x.BlogTitle).MinimumLength(4).WithMessage("Blog Title Must Be At Least 4 Characters");
            RuleFor(x => x.BlogTitle).MaximumLength(100).WithMessage("Blog Title Must Be At Most 100 Characters");
            RuleFor(x => x.BlogContent).MinimumLength(2).WithMessage("Blog Content Must Be At Least 2 Characters");
            RuleFor(x => x.BlogContent).MaximumLength(1000).WithMessage("Blog Content Must Be At Most 1000 Characters");
        }
    }
}
