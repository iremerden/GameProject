using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamesManager : IGamesService
    {
        private GamesManager gamesManager;

        public GamesManager()
        {
        }

        public GamesManager(GamesManager gamesManager)
        {
            this.gamesManager = gamesManager;
        }

        public void Add(Games game)
        {
            Console.WriteLine("New Game Added.");
        }

        public void Delete(Games game)
        {
            Console.WriteLine("Selected Game is Deleted");
        }

        public void Update(Games game)
        {
            Console.WriteLine("New Updates Imposed to the Selected Game.");
        }
    }
}
