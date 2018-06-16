namespace CodeOfKutulu
{
    public class YellEffect : Effect
    {
        public readonly int TargetId;

        public YellEffect(Vec origin, int timeLeft, int creatorId, int targetId) :
            base(origin, timeLeft, creatorId)
        {
            TargetId = targetId;
        }
    }
}