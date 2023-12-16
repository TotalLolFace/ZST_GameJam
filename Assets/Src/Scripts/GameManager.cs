using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameDate gameDate = new GameDate();
    public PartyManager PM = new PartyManager();

    private void Start() {
        PM.partyName = PartyName.KONFEDERACJA;
        PM.partyType = PartyType.RIGHT;

        Dispatcher.DateChanged += (s, e) => Debug.Log($"Hello World from T:{gameDate.Week}/M:{gameDate.Month}/R:{gameDate.Year}!");
    }

    private void Update() {
        if (Input.GetMouseButtonDown(1)) {
            this.NextTurn();
        }
    }

    public void NextTurn() {
        gameDate.AddWeek();
        
        Dispatcher.DispatchDateChanged(this, new CustomArgs.DateChangedArgs(this.gameDate));
    }
}
