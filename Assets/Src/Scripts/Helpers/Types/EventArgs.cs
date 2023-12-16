using System;

namespace CustomArgs {
    public class DateChangedArgs : EventArgs {
        public GameDate gameDate;
        public uint turns;

        public DateChangedArgs(GameDate gameDate, uint turns) {
            this.gameDate = gameDate;
            this.turns = turns;
        }
    }
}
