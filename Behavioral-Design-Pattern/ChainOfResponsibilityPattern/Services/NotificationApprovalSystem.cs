using System;

namespace ChainOfResponsibilityPattern.Services
{
    public static class NotificationApprovalSystem
    {
        internal static void DriverMethod()
        {
            IHandler teamLead = new TeamLeadHandler();
            IHandler manager = new ManagerHandler();
            IHandler director = new DirectorHandler();

            // Set up the chain: TeamLead -> Manager -> Director
            teamLead.SetNext(manager).SetNext(director);

            // Example: Send different requests through the chain
            Console.WriteLine("Processing LowPriority request:");
            teamLead.Handle(RequestTypes.LowPriority);

            Console.WriteLine("\nProcessing MediumPriority request:");
            teamLead.Handle(RequestTypes.MediumPriority);

            Console.WriteLine("\nProcessing HighPriority request:");
            teamLead.Handle(RequestTypes.HighPriority);

            Console.WriteLine("\nProcessing UnknownPriority request:");
            teamLead.Handle(RequestTypes.SystemBug);
        }
    }

    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Handle(RequestTypes request);
    }

    public class TeamLeadHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public void Handle(RequestTypes request)
        {
            if (RequestTypes.LowPriority == request)
            {
                Console.WriteLine("Team Lead approved the notification.");
            }
            else
            {
                Console.WriteLine("Team Lead can't approve. Passing to Manager.");
                _nextHandler?.Handle(request);
            }
        }
    }

    public class ManagerHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public void Handle(RequestTypes request)
        {
            if (request == RequestTypes.MediumPriority)
            {
                Console.WriteLine("Manager approved the notification.");
            }
            else
            {
                Console.WriteLine("Manager can't approve. Passing to Director.");
                _nextHandler?.Handle(request);
            }
        }
    }

    public class DirectorHandler : IHandler
    {
        public IHandler SetNext(IHandler handler)
        {
            // End of chain, so no next handler to set
            return null;
        }

        public void Handle(RequestTypes request)
        {
            if (request == RequestTypes.HighPriority)
                Console.WriteLine("Director approved the notification.");
            else
                Console.WriteLine("Request not approved by any handler.");
        }
    }
}