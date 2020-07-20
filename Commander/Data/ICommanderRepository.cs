using System;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepository
    {
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);
    }
}
