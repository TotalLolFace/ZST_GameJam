public class PartyManager {
    private uint partyPrivilges;
    private byte polePartySupport;
    private byte realPartySupport;
    public PartyType partyType;
    public PartyName partyName;

    public uint PP {
        set {
            this.partyPrivilges = value;
        }
        get {
            return partyPrivilges;
        }
    }

    public byte PPS {
        set {
            this.polePartySupport = value;
        }
        get {
            return this.polePartySupport;
        }
    }

    public byte RPS {
        set {
            this.realPartySupport = value;
        }
        get {
            return this.realPartySupport;
        }
    }

    public PartyManager() {
        this.PP = 100;
        this.PPS = 100;
        this.RPS = 100;
    }
}
