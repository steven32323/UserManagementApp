using System;
using System.Collections.Generic;
using MyApp.Data;
using MyApp.Models;
using MyApp.Services.Domain.Implementations.Base;
using MyApp.Services.Domain.Interfaces;

namespace MyApp.Services.Domain.Implementations
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public UserService(IDataAccess dataAccess) : base(dataAccess) { }

        /// <summary>
        /// Return users by active state
        /// </summary>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public IEnumerable<User> FilterByActive(bool isActive)
        {
            throw new NotImplementedException();
        }

        public override User Create(User user)
        {
            user = base.Create(user);
            user.ActionLogs.Add(new ActionLog
            {
                UserId = user.Id,
                ActionType = "Add",
                ActionDate = DateTime.UtcNow
            });

            return user;
        }

        public override User Update(User user)
        {
            user = base.Update(user);
            user.ActionLogs.Add(new ActionLog
            {
                UserId = user.Id,
                ActionType = "Edit",
                ActionDate = DateTime.UtcNow
            });

            return user;
        }

        public override void Delete(User user)
        {
            base.Delete(user);
            user.ActionLogs.Add(new ActionLog
            {
                UserId = user.Id,
                ActionType = "Delete",
                ActionDate = DateTime.UtcNow
            });
        }
    }
}
