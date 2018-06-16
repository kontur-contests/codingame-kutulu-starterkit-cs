using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOfKutulu
{
    public class YellAction : IGameAction
    {
        public string Message { get; }

        YellAction() : this("") { }

        YellAction(string message)
        {
            Message = message;
        }

        public Cancelable ApplyTo(State state)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
            => "YELL " + Message;
    }
}
