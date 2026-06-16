using System;
using EFA.Commands;
using EFA.Core;

namespace EFA.Commands
{
    
    public class EFABless : ICommandable
    {
        public enum EFAAnswer
        {
            Smile,
            Lol,
            Byby
        }
        
        private static readonly int totalAnswers = Enum.GetNames(typeof(EFAAnswer)).Length;
        public void Execute(string args)
        {
            EFAAnswer answerRand = (EFAAnswer)Random.Shared.Next(0,totalAnswers);

            switch (answerRand)
            {
                
                case EFAAnswer.Smile:
                    Console.WriteLine("))");
                break;
                case EFAAnswer.Lol:
                    Console.WriteLine("XD");
                break;
                case EFAAnswer.Byby:
                    Console.WriteLine("bye bye, why TT");
                break;

            }
            
        }

    }

}