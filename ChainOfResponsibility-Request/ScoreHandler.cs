namespace ChainOfResponsibility_Request
{
    internal class ScoreHandler : Handler
    {
        public override void Handle(User user)
        {
            if (user.Score >= 0)
            {
                Console.WriteLine($"{user.Score} корректен");
                _next?.Handle(user);
            }
            else
            {
                Console.WriteLine($"{user.Score} не корректен");
                return;
            }
        }
    }
}
