using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Services.Models;

namespace Services.DataAccess
{
    public class DatabaseHelper
    {
        public DatabaseHelper()
        {
            sessionFactory = Fluently.Configure()
                                     .Database(MySQLConfiguration.Standard.ConnectionString(_connectionString))
                                     .Mappings(m =>

                         m.FluentMappings

                             .AddFromAssemblyOf<User>())

                   .ExposeConfiguration(cfg => new SchemaExport(cfg)

                .Create(false, false))

               .BuildSessionFactory();


                                     
        }

        public ISessionFactory GetDatabase()
        {
            return sessionFactory;
        }

        private ISessionFactory sessionFactory { get; set; }
        private string _connectionString = "server=127.0.0.1;uid=root;" +
            "database=rabail_test";

    }
}
