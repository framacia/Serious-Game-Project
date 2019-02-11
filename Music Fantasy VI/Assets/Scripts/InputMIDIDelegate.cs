using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMIDIDelegate : MonoBehaviour {

    public event Action<bool> CDown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void MIDIInput()
    {
        //C note
        if (MidiJack.MidiMaster.GetKeyDown(0, 48) || Input.GetKeyDown(KeyCode.A))
        {
            CDown(true);
        }

        if (MidiJack.MidiMaster.GetKeyUp(0, 48) || Input.GetKeyUp(KeyCode.A))
        {
            CDown(false);
            print("note played");
        }

    }
}
