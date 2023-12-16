using System;

namespace CustomArgs {
    public class DateChangedArgs : EventArgs {
        public GameDate gameDate;

        public DateChangedArgs(GameDate gameDate) {
            this.gameDate = gameDate;
        }
    }
}
