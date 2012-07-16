namespace OpenLeague.Model.Command
{
    using System;

    using OpenLeague.Infrastructure.Commands;

    public class ContestDeleteCommand : ICommand
    {
        private readonly Guid contestId;

        public ContestDeleteCommand(Guid contestId)
        {
            this.contestId = contestId;
        }

        public Guid Id 
        { 
            get
            {
                return contestId; 
            } 
        }
    }
}