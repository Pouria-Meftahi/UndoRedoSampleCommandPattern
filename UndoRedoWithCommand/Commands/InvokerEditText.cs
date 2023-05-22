using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoRedoWithCommand.Commands
{
    public class InvokerEditText
    {

        Reciver_EditText editText = new Reciver_EditText();
        List<Command> commands = new List<Command>();
        int current = 0;

        public string ExecuteCommand(string input)
        {
            Command command = new Concreate_AddTextToLable(editText);
            string result = command.Execute(input);

            commands.Add(command);
            current++;

            return result;
        }


        public string Undo()
        {
            Command command = commands[--current];
            return command.UnExecute(command.CurrentInput);
        }

        public string Redo()
        {
            Command command = commands[current++];
            return command.Execute(command.CurrentInput);
        }
    }
}
