using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeOfKutulu
{
    [TestFixture]
    class Ai_Tests
    {
        [TestCase("19|19|#########.#########|#...#...#.#...#...#|#.#...#.#.#.#...#.#|#.##.##.###.##.##.#|#.................#|#.##.##.#.#.##.##.#|#.##.#..#.#..#.##.#|#......##.##......#|####.###w.w###.####|...#.....#.....#...|####.###w.w###.####|#......##.##......#|#.##.#..#.#..#.##.#|#.##.##.#.#.##.##.#|#.................#|#.##.##.###.##.##.#|#.#...#.#.#.#...#.#|#...#...#.#...#...#|#########.#########|3 1 3 40|4|EXPLORER 0 4 4 250 2 3|EXPLORER 1 14 4 250 2 3|EXPLORER 2 4 14 250 2 3|EXPLORER 3 14 14 250 2 3|",
            "WAIT")]
        public void GetActionTest(string data, string expectedAction)
        {
            var ai = new Ai();
            var reader = new StateReader(data);
            var initData = reader.ReadInitData();
            var nextAction = ai.GetNextAction(reader.ReadState(initData), new Countdown(50)).ToString();
            Assert.That(nextAction, Is.EqualTo(expectedAction));
        }
    }
}
