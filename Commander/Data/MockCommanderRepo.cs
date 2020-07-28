using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepository
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommands(Command cmd)
        {
            throw new NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle and Pan" };
        }

        public IEnumerable<Command> GetCommands()
        {

            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo="Boil an egg", Line="Boil water", Platform = "Kettle and Pan"},
                new Command { Id = 1, HowTo="Cut Bread", Line="Get a knife", Platform = "knife and chopping board"},
                new Command { Id = 2, HowTo="Make cup of tea", Line="Place teabag in cup", Platform = "Kettle and cup"}
            };
            return commands;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
