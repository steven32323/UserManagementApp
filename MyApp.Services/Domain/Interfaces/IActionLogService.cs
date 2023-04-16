using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyApp.Models;
using MyApp.Services.Domain.Interfaces.Base;

namespace MyApp.Services.Domain.Interfaces
{
    public interface IActionLogService : IServiceBase<ActionLog>
    {
        // Add any additional methods specific to ActionLog objects here, if needed.
    }
}