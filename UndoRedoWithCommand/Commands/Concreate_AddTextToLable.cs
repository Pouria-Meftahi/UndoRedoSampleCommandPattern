using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoRedoWithCommand.Commands
{
    public class Concreate_AddTextToLable : Command
    {
        public Concreate_AddTextToLable(Reciver_EditText reciver_EditText)
            : base(reciver_EditText)
        {

        }

        public override string Execute(string input)
        {
            CurrentInput = input;
            return reciver_EditText.AddText(input);
        }

        public override string UnExecute(string input)
        {
            CurrentInput = input;
            return reciver_EditText.RemoveText(input);
        }
    }
}
