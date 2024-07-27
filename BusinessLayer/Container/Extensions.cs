using BusinessLayer.Abstract;
using BusinessLayer.Abstract.AbstractUow;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.ConcreteUow;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies( this IServiceCollection services)
        {
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();
            
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDal, EfFeatureDal>();
            
            services.AddScoped<IFeature2Service, Feature2Manager>();
            services.AddScoped<IFeature2Dal, EfFeature2Dal>();
            
            services.AddScoped<ISubAboutService, SubAboutManager>();
            services.AddScoped<ISubAboutDal, EfSubAboutDal>();
            
            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();
            
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();
            
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IExcelService,ExcelManager>();
            services.AddScoped<IPdfService,PdfManager>();

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();

            services.AddScoped<IUowDal, UowDal>();
        }
    }
}
