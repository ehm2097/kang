using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Kang.Core;

namespace Kang.Lite
{
    class NodeCommander
    {
        public INodeCommand GetCommand(string id)
        {
            if(!_commands.ContainsKey(id))
            {
                var script = _scriptFactory.GetScript(id);
                _commands[id] = new Command(script);
            }

            return _commands[id];
        }

        private Dictionary<string, Command> _commands = new Dictionary<string, Command>();
        private ScriptFactory _scriptFactory = new ScriptFactory();

        private class Command: INodeCommand 
        {
            public Command(string script)
            {
                _dbCommand.CommandType = System.Data.CommandType.Text;
                _dbCommand.CommandText = script;
                _applyArgs = _binder.Bind(_dbCommand);
                _dbCommand.Prepare();
            }

            public void IterateNodes(NodeCommandArgs args, Action<ContentNode> action)
            {
                _applyArgs(args);
                using(var reader = _dbCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        throw new NotImplementedException();
                    }
                }
            } 

            private CommandBinder _binder = new CommandBinder();
            private SqliteCommand _dbCommand = new SqliteCommand();
            private Action<NodeCommandArgs> _applyArgs;
        }

        private class Binding
        {
            
        }
    }   
}