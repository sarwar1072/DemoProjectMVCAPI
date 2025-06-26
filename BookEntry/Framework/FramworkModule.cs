using Autofac;
using Framework.RepogitoryFold;
using Framework.ServicesFold;
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

            builder.RegisterType<BookRepo>().As<IBookRepo>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WriterRepo>().As<IWriterRepo>().InstancePerLifetimeScope();
            builder.RegisterType<ProjectUnitOfWork>().As<IProjectUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<BookServices>().As<IBookServices>().InstancePerLifetimeScope();
            builder.RegisterType< WriterServices >().As<IWriterServices>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
