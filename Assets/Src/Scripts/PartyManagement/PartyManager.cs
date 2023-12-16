using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPartyManager
{
    private static CParty m_pCurrentParty;
    
    public static void CreateParty(string name)
    {
        m_pCurrentParty = new CParty(name);
    }
}