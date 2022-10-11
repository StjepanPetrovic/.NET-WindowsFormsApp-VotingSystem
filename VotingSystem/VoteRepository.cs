using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    internal class VoteRepository
    {
        public static int SumAbstained { get; set; } = 0;
        public static int SumAgainst { get; set; } = 0;
        public static int SumFor { get; set; } = 0;

        public static List<Voter> voters = new List<Voter>();

        public static bool AlreadyVote(string OIB)
        {
            foreach (Voter voter in voters)
            {
                if (voter.OIB == OIB)
                {
                    return true;
                }
            }
            return false;
        }

        public static void NewVoter(Voter voter)
        {
            voters.Add(voter);
        }
    }
}
