using System;
using System.Linq;

namespace CodeOfKutulu
{
    public class BaseStateReader
    {
        protected string lastLine;
        protected bool logToError = true;
        protected Func<string> readLine;

        public BaseStateReader(string input)
        {
            var lines = input.Split('|');
            var index = 0;
            logToError = false;
            readLine = () => index < lines.Length ? lines[index++] : null;
        }

        public BaseStateReader(Func<string> consoleReadLine)
        {
            readLine = () =>
            {
                lastLine = consoleReadLine();
                if (logToError)
                    Console.Error.Write(lastLine + "|");
                return lastLine;
            };
        }

        public int ReadInt() => int.Parse(readLine());

        public int[] ReadInts() => readLine().Split().Select(int.Parse).ToArray();

        public Vec ReadVec() => Vec.Parse(readLine());
    }
}