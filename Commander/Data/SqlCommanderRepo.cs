using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepository
    {
        private readonly CommanderContext context;

        public SqlCommanderRepo(CommanderContext context)
        {
            this.context = context;
        }

        public Command GetCommandById(int id)
        {
            return context.Commands.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Command> GetCommands()
        {
            return context.Commands.ToList();
        }
    }
}
