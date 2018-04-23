using System;

namespace CatLover
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Problem1");

			int[] catParticipate = new int[3];
			int winnerVotes = 0;
            int winner = 0;

			Console.Write("Number of Persons in Jury : ");
			int numPeople = int.Parse(Console.ReadLine());


            int[] catVote = new int[numPeople];
            for (int i = 0; i < numPeople; i++){
				int numVote = int.Parse(Console.ReadLine());

				if (!(numVote <= 0 || numVote >= 4))
				{
					catParticipate[numVote-1]++;

                }else{
					Console.Write("Wrong Number");
                    throw new Exception();
                }
            }

            winnerVotes = catParticipate[0];
            for (int i = 0; i < catParticipate.Length; i++)
            {
                if(catParticipate[i] >= winnerVotes){
                    winnerVotes = catParticipate[i];
                    winner = i + 1;
                }
            }

            Console.Write("Winner is...");
            Console.WriteLine(winner);
        }
    }
}
