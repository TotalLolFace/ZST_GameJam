public class GameDate {
    private byte week;
    private byte month;
    private uint year;

    public byte Week {
        private set { }
        get { return this.week; }
    }

    public byte Month {
        private set { }
        get { return this.month; }
    }

    public uint Year {
        private set { }
        get { return this.year; }
    }

    public GameDate() {
        this.year = 2023;
        this.month = 12;
        this.week = 3;
    }

    public void AddWeek() {
        if (this.week + 1 > 4) {
            this.week = 1;
            AddMonth();
        }
        else {
            this.week++;
        }
    }

    public void AddMonth() {
        if (this.month + 1 > 12) {
            this.month = 1;
            AddYear();
        }
        else {
            this.month++;
        }
    }

    public void AddYear() {
        this.year++;
    }
}
