using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public  class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //kural ver= rulefor
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p=>p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            //diyoruz ki eğer kategori içecek ise unit price 10 ve 10 danbüyük büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);

            //diyelim ürün adlarım a ile başlamalı istiyoruz
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("ürünler a harfi ile başlamalı");
        }

        private bool StartWithA(string arg)//arg gönderdiğimiz productname
        {
            return arg.StartsWith("A");
        }
    }
}
