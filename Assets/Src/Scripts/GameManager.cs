using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour {
    public static GameManager Instance { get; private set; }
    
    public GameDate gameDate = new GameDate();
    public uint turns = 0;
    
    #region Party Management
    [SerializeField] private Sprite[] m_pPortraits;
    
    /// <summary>
    /// Current player's Political Party
    /// </summary>
    private CParty m_pCurrentParty;
    
    public void CreateParty(CParty.PartyName name, CParty.PartyType type)
    {
        m_pCurrentParty = new CParty(name, type);
    }
    
    public Sprite RandomPortrait()
    {
        return GameManager.Instance.Portraits()[Random.Range(0, GameManager.Instance.Portraits().Length)];
    }
    #endregion

    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(this);
        Instance = this;
        DontDestroyOnLoad(this);
    }
    
    private void Start() {
        CreateParty(CParty.PartyName.KONFEDERACJA, CParty.PartyType.RIGHT);

        var ev = new DateEvent(new GameDate(2024, 3, 1));

        /*Dispatcher.DateChanged += ev.Dispatch;*/
        Dispatcher.DateChanged += (s, e) => Debug.Log($"T:{gameDate.Week}/M:{gameDate.Month}/R:{gameDate.Year} T:{this.turns}!");
    }

    public void NextTurn() {
        gameDate.AddWeek();
        this.turns++;
        
        Dispatcher.DispatchDateChanged(this, new CustomArgs.DateChangedArgs(this.gameDate, this.turns));
    }
    
    public Sprite[] Portraits()
    {
        return m_pPortraits;
    }
}
