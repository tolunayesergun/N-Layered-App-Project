using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p =>p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz.");
           // RuleFor(p => p.ProductName).Must(StartWithA);

            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Ürün kategorisi boş olamaz.");

            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Ürün fiyatı boş olamaz.");
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(0).WithMessage("Ürün fiyatı 0 dan küçük olamaz");
            // RuleFor(p => p.UnitPrice).GreaterThan(2).When(p => p.CategoryId == 2);
           
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Ürün Birim Adedi boş olamaz.");

            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Ürün Stok bilgisi boş olamaz.");
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0).WithMessage("Ürün stoğu 0 dan küçük olamaz");

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
