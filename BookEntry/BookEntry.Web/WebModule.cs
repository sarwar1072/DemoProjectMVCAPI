using Autofac;
using BookEntry.Web.Models;

namespace BookEntry.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            //builder.RegisterType< BookingRequestViewModel >().AsSelf().InstancePerLifetimeScope();
             builder.RegisterType< FileHelper >().As<IFileHelper >().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
