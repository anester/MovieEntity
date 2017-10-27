using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Db
{
    public class MovieDataModule : Module
    {
        public string ConnectionString { get; set; }
        public static string ModuleNamespace => "Movie.Db";

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.Register((c) =>
            {
                MovieContextFactory factory = new MovieContextFactory();
                var context = factory.CreateDbContext(new string[] { ConnectionString });
                return context;
            }).AsSelf().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(MovieContext).Assembly)
                   .Where(t => t.Namespace.StartsWith("Movie.Db.Implementation"))
                   .AsImplementedInterfaces();
        }
    }
}
