using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOfKutulu
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var reader = new StateReader();
            var initData = reader.ReadInitData();
            var ai = new Ai();
            while (true)
            {
                var state = reader.ReadState(initData);
                var countdown = new Countdown(45);
                var move = ai.GetNextAction(state, countdown);
                Console.Error.WriteLine(countdown);
                Console.WriteLine(move);
            }
        }
    }
}
