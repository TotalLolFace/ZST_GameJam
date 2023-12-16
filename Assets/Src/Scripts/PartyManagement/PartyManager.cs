using UnityEngine;

public class CPartyManager
{
    /// <summary>
    /// Current player's Political Party
    /// </summary>
    private CParty m_pCurrentParty;
    
    public void CreateParty(string name)
    {
        m_pCurrentParty = new CParty(name);
    }
    
    public Sprite RandomPortrait()
    {
        return GameManager.Instance.Portraits()[Random.Range(0, GameManager.Instance.Portraits().Length)];
    }
}