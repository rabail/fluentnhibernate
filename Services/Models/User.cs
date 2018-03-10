using System;
using FluentNHibernate.Mapping;

namespace Services.Models
{
    public class User
    {
        public virtual long UserId
        {
            get; set;
        }

        public virtual string FirstName
        {
            get; set;
        }

        public virtual string LastName
        {
            get; set;
        }
    }

    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x=> x.UserId);
            Map(x => x.FirstName);
            Map(x => x.LastName);


            Table("User");
        }
    }
}
