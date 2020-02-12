using System;
using System.Collections.Generic;
using System.Text;

namespace PigDice {
    public class PigDiceGame {
        private Random rnd = new Random(DateTime.Now.Millisecond);
        public int RollTheDie() {
            return rnd.Next(1, 7);
        }
        public int PigDice() {
            var score = 0;
            var roll = RollTheDie();
            while(roll != 1) {
                score += roll;
                roll = RollTheDie();
            }
            return score;
        }
        public void Play() {
            var WorldRecordScore = 566;
            var HighScore = 0;
            var GamesToPlay = 100000;
            while (GamesToPlay > 0 || HighScore<WorldRecordScore) {
                var score = PigDice();
                if (score > HighScore) {
                    HighScore = score;
                }
                GamesToPlay--;
            }
            Console.WriteLine($"New World Record is {HighScore}");
        }
    }
}
