using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    #region Party Management

    [SerializeField] private Sprite[] m_pPortraits;  
    #endregion
    
    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(this);
        Instance = this;
        DontDestroyOnLoad(this);
    }

    #region Party Related
    public Sprite RandomizePersonImage()
    {
        return m_pPortraits[Random.Range(0, m_pPortraits.Length)];
    }
    #endregion
}
