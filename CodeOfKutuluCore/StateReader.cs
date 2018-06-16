using System;
using System.Collections.Generic;

namespace CodeOfKutulu
{
    public class StateReader : BaseStateReader
    {
        public StateReader(string input) : base(input)
        {
        }

        public StateReader() : base(Console.ReadLine)
        {
        }

        private Cell CharToCell(char c)
        {
            switch(c)
            {
                case '.':
                    return Cell.Empty;
                case '#':
                    return Cell.Wall;
                case 'w':
                    return Cell.Spawn;
                case 'U':
                    return Cell.Shelter;
                default:
                    throw new NotImplementedException();
            }
        }

        public State ReadState(InitData initData)
        {
            var entityCount = ReadInt();
            Explorer me = null;
            var others = new List<Explorer>();
            var wanderers = new List<Wanderer>();
            var slashers = new List<Slasher>();
            var lightEffects = new List<LightEffect>();
            var planEffects = new List<PlanEffect>();
            var yellEffects = new List<YellEffect>();
            var shelterEffects = new List<ShelterEffect>();
            for(var i = 0; i < entityCount; ++i)
            {
                var line = readLine().Split(' ');
                var entityType = line[0];
                var id = int.Parse(line[1]);
                var position = new Vec(int.Parse(line[2]), int.Parse(line[3]));
                if (entityType == "EXPLORER")
                {
                    var sanity = int.Parse(line[4]);
                    var plansLeft = int.Parse(line[5]);
                    var lightsLeft = int.Parse(line[6]);
                    var explorer = new Explorer(id, position, sanity, plansLeft, lightsLeft);
                    if (i == 0)
                        me = explorer;
                    else
                        others.Add(explorer);
                }
                else if (entityType == "WANDERER")
                {
                    var lifeTime = int.Parse(line[4]);
                    var state = (Wanderer.State)int.Parse(line[5]);
                    var targetId = int.Parse(line[6]);
                    wanderers.Add(new Wanderer(id, position, lifeTime, state, targetId));
                }
                else if (entityType == "SLASHER")
                {
                    var stateChangeTimeout = int.Parse(line[4]);
                    var state = (Slasher.State)int.Parse(line[5]);
                    var targetId = int.Parse(line[6]);
                    slashers.Add(new Slasher(id, position, stateChangeTimeout, state, targetId));
                }
                else if(entityType == "EFFECT_SHELTER")
                {
                    var remainingEnergy = int.Parse(line[4]);
                    shelterEffects.Add(new ShelterEffect(position, remainingEnergy));
                }
                else
                {
                    var lifeTime = int.Parse(line[4]);
                    var creatorId = int.Parse(line[5]);
                    if (entityType == "EFFECT_PLAN")
                        planEffects.Add(new PlanEffect(position, lifeTime, creatorId));
                    else if (entityType == "EFFECT_LIGHT")
                        lightEffects.Add(new LightEffect(position, lifeTime, creatorId));
                    else if (entityType == "EFFECT_YELL")
                    {
                        var targetId = int.Parse(line[6]);
                        yellEffects.Add(new YellEffect(position, lifeTime, creatorId, targetId));
                    }
                    else
                        throw new NotImplementedException();
                }
            }
            return new State(initData, me, others, wanderers, slashers,
                planEffects, lightEffects, yellEffects, shelterEffects);
        }

        public InitData ReadInitData()
        {
            var width = ReadInt();
            var height = ReadInt();
            var map = new Cell[height, width];
            for(var i = 0; i < height; ++i)
            {
                var row = readLine();
                for (var j = 0; j < width; ++j)
                    map[i, j] = CharToCell(row[j]);
            }
            var stats = ReadInts();
            return new InitData(map, stats[0], stats[1], stats[2], stats[3]);
        }
    }
}