using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CG.WondevWoman
{
    public class StateEvaluator : IStateEvaluator
    {
        private const int ScoreCoefficent = 100;
        private const int HeightCoefficent = 50;
        private const int AvailableActionsCoefficent = 12;
        

        public ExplainedScore Evaluate(State state, int playerIndex)
        {
            //var oldPlayer = state.CurrentPlayer;
            //if(state.CurrentPlayer != playerIndex)
            //    state.ChangeCurrentPlayer();
            //var result = ScoreCoefficent * state.GetScore(playerIndex) +
            //             HeightCoefficent * state.GetUnits(playerIndex).Where(x => x.X >= 0).Average(state.HeightAt) +
            //             AvailableActionsCoefficent * state.GetPossibleActions().Count;
            //if (state.CurrentPlayer != oldPlayer)
            //    state.ChangeCurrentPlayer();
            var result = 0.1 * state.GetPossibleActions().Count + state.MyUnits.Sum(state.HeightAt);
            return result;
        }

    }
}
