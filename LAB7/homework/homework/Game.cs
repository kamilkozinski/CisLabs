using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Game
    {
        private List<ICommand> commandsOnStart;
        private List<ICommand> commandsOnFinish;
        private List<ICommand> commandsOnGoing;

        private Weapon gun;
        public Game(Weapon m_gun)
        {
            commandsOnStart = new List<ICommand>();
            commandsOnFinish = new List<ICommand>();
            commandsOnGoing = new List<ICommand>();
            gun = m_gun;
        }

        public void AddToStart(ICommand command)
        {
            commandsOnStart.Add(command);
        }
        public void AddToFinish(ICommand command)
        {
            commandsOnFinish.Add(command);
        }
        public void AddOnGoing(ICommand command)
        {
            commandsOnGoing.Add(command);
        }

        public void StartRound()
        {
            foreach (ICommand com in commandsOnStart)
            {
                com.Execute(gun);
            }
        }
        public void FinishRound()
        {
            foreach (ICommand com in commandsOnFinish)
            {
                com.Execute(gun);
            }
        }
        public void PlayRound()
        {
            foreach (ICommand com in commandsOnGoing)
            {
                com.Execute(gun);
            }
        }
    }
}
