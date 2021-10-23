using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
   public class AutofacBusinessModule:Module
    {
        //override space bas load'ı seç
        protected override void Load(ContainerBuilder builder)
        {
            //biri senden productservis isterse ona bir productmanager örneği ver
            //webapi startup da yaptığımız şeyin autofac ile yapılışı 
            //webapi de neden yapmadık çünkü web api ye bağımlı kalmasın ilerde farklı bir api ile 
            //çalırsak bu yapıyı olduğu gibi ondada kullanabilelim diye business da yapıyoruz.
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<OrderManager>().As<IOrderService>().SingleInstance(); 
            builder.RegisterType<EfOrderDal>().As<IOrderDal>().SingleInstance();


            builder.RegisterType<OrderDetailManager>().As<IOrderDetailService>().SingleInstance();
            builder.RegisterType<EfOrderDetailDal>().As<IOrderDetailDal>().SingleInstance();

            builder.RegisterType<BasketManager>().As<IBasketService>().SingleInstance();
            builder.RegisterType<EfBasketDal>().As<IBasketDal>().SingleInstance();

            builder.RegisterType<BasketDetailManager>().As<IBasketDetailService>().SingleInstance();
            builder.RegisterType<EfBasketDetailDal>().As<IBasketDetailDal>().SingleInstance();


            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            //builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }

    }
}
