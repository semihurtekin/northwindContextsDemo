using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("ÜRÜN ADI BOŞ OLAMAZ");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2).WithMessage("2 den nüyükse 10 dan büyük");
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("A ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A") || arg.StartsWith("a");
        }
    }
}
