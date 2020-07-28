using System;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepository
    {
        bool SaveChanges();

        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommands(Command cmd);

    }
}
