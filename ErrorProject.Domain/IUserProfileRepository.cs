using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalTests.Domain
{
    public interface IUserProfileRepository
    {
        IQueryable<UserProfile> All { get; }

        UserProfile CurrentUser { get; }

        void InsertOrUpdate(UserProfile user);

        void Remove(UserProfile user);

        void Save();
    }
}