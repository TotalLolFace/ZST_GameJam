using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPartyMember
{
    private string m_szFirstName, m_szLastName;
    private Sprite m_pPortrait;
    
    public CPartyMember(string szFirstName, string szLastName)
    {
        m_szFirstName = szFirstName;
        m_szLastName = szLastName;
        m_pPortrait = GameManager.Instance.RandomPortrait();
    }

    public Sprite Portrait()
    {
        return m_pPortrait;
    }

    public string FirstName()
    {
        return m_szFirstName;
    }

    public string LastName()
    {
        return m_szLastName;
    }

    public bool Equals(string szFirstName, string szLastName)
    {
        return m_szFirstName.Equals(szFirstName) && m_szLastName.Equals(szLastName);
    }
}

public class CParty
{
    public enum PartyName {
        KO,
        PIS,
        PSL,
        PL2050,
        KONFEDERACJA,
        LEWICA
    }
    
    public enum PartyType {
        LEFT,
        CENTER,
        RIGHT
    }
    
    private PartyName m_eName;
    private PartyType m_eType;
    private uint partyPrivilges;
    private byte polePartySupport;
    private byte realPartySupport;
    private List<CPartyMember> m_pMembers;
    // TODO: Add party's statistics ~GabrielV

    public CParty(PartyName eName, PartyType eType)
    {
        m_eName = eName;
        m_eType = eType;
        PP = 100;
        PPS = 100;
        RPS = 100;
    }
    
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

    public string Name()
    {
        return m_eName.ToString();
    }

    public List<CPartyMember> Members()
    {
        return m_pMembers;
    }

    public bool HasMember(string szFirstName, string szLastName)
    {
        return m_pMembers.Contains(GetMember(szFirstName, szLastName));
    }
    
    public CPartyMember GetMember(string szFirstName, string szLastName)
    {
        foreach (CPartyMember pMember in m_pMembers) if (pMember.Equals(szFirstName, szLastName)) return pMember;
        return null;
    }

    public void AddMember(CPartyMember pMember)
    {
        m_pMembers.Add(pMember);
    }

    public void RemoveMember(string szFirstName, string szLastName)
    {
        m_pMembers.Remove(GetMember(szFirstName, szLastName));
    }
}