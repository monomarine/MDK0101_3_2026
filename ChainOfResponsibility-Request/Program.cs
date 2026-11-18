namespace ChainOfResponsibility_Request
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("example@gmail.com", "+799966688844", 10);
            User user2 = new User("example@gmail.com", "+799966688844", -10);

            //объекты звеньев цепи
            EmailHandler eh = new EmailHandler();
            Phonehandler ph = new Phonehandler();
            ScoreHandler sh = new ScoreHandler();

            //связывание звеньев
            sh.SetNext(eh);
            eh.SetNext(ph);

            sh.Handle(user1);
            sh.Handle(user2);
        }
    }
}
