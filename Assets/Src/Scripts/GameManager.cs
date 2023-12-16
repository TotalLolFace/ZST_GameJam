using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    #region Party Management
    [SerializeField] private Sprite[] m_pPortraits;
    
    public CPartyManager PartyManager { get; private set; }
    #endregion

    private void Init()
    {
        PartyManager = new CPartyManager();
    }
    
    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(this);
        Instance = this;
        DontDestroyOnLoad(this);
        
        Init();
    }

    public Sprite[] Portraits()
    {
        return m_pPortraits;
    }
}
