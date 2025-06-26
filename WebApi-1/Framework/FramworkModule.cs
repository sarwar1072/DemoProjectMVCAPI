using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class FramworkModule:Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;
        private readonly string _webHostEnvironment;

        public FramworkModule(string connectionString, string migrationAssemblyName,
            string webHostEnvironment)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
            _webHostEnvironment = webHostEnvironment;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AppDbcontext>().AsSelf()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<OrderRepo>().As<IOrderRepo>()
                .InstancePerLifetimeScope();

            //builder.RegisterType<OrderItemRepogi>().As<IOrderItemRepogi>().InstancePerLifetimeScope();
            builder.RegisterType<OrderUnitofwork>().As<IOrderUnitofwork>().InstancePerLifetimeScope();
            builder.RegisterType<OrderServices>().As<IOrderServices>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
