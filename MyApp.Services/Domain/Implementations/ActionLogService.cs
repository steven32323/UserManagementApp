using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Data;
using MyApp.Models;
using MyApp.Services.Domain.Implementations.Base;
using MyApp.Services.Domain.Interfaces;

namespace MyApp.Services.Domain.Implementations
{
    public class ActionLogService : ServiceBase<ActionLog>, IActionLogService
    {
        public ActionLogService(IDataAccess dataAccess) : base(dataAccess) { }

        // Add any additional methods specific to ActionLogService here
    }
}
