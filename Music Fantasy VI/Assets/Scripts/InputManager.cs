using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class InputManager : MonoBehaviour {

    public AudioClip clipA;
    public AudioClip clipASharp;
    public AudioClip clipB;
    public AudioClip clipC;
    public AudioClip clipCSharp;
    public AudioClip clipD;
    public AudioClip clipDSharp;
    public AudioClip clipE;
    public AudioClip clipF;
    public AudioClip clipFSharp;
    public AudioClip clipG;
    public AudioClip clipGSharp;

    private AudioSource audioA;
    private AudioSource audioASharp;
    private AudioSource audioB;
    private AudioSource audioC;
    private AudioSource audioCSharp;
    private AudioSource audioD;
    private AudioSource audioDSharp;
    private AudioSource audioE;
    private AudioSource audioF;
    private AudioSource audioFSharp;
    private AudioSource audioG;
    private AudioSource audioGSharp;

	// Use this for initialization
	void Start () {

        //TODO Locate Piano group and route the audio sources to that
        //AudioMixer audioMixer = Resources.Load<AudioMixer>("Master");
        //AudioMixerGroup[] audioMixGroup = audioMixer.FindMatchingGroups("Master");

        audioA = gameObject.AddComponent<AudioSource>();
        audioASharp = gameObject.AddComponent<AudioSource>();
        audioB = gameObject.AddComponent<AudioSource>();
        audioC = gameObject.AddComponent<AudioSource>();
        audioCSharp = gameObject.AddComponent<AudioSource>();
        audioD = gameObject.AddComponent<AudioSource>();
        audioDSharp = gameObject.AddComponent<AudioSource>();
        audioE = gameObject.AddComponent<AudioSource>();
        audioF = gameObject.AddComponent<AudioSource>();
        audioFSharp = gameObject.AddComponent<AudioSource>();
        audioG = gameObject.AddComponent<AudioSource>();
        audioGSharp = gameObject.AddComponent<AudioSource>();

        audioA.clip = clipA;
        audioASharp.clip = clipASharp;
        audioB.clip = clipB;
        audioC.clip = clipC;
        audioCSharp.clip = clipCSharp;
        audioD.clip = clipD;
        audioDSharp.clip = clipDSharp;
        audioE.clip = clipE;
        audioF.clip = clipF;
        audioFSharp.clip = clipFSharp;
        audioG.clip = clipG;
        audioGSharp.clip = clipGSharp;

        //audioA.outputAudioMixerGroup = audioMixGroup[0];
        //audioASharp.outputAudioMixerGroup = audioMixGroup[0];
        //audioB.outputAudioMixerGroup = audioMixGroup[0];
        //audioC.outputAudioMixerGroup = audioMixGroup[0];
        //audioCSharp.outputAudioMixerGroup = audioMixGroup[0];
        //audioD.outputAudioMixerGroup = audioMixGroup[0];
        //audioDSharp.outputAudioMixerGroup = audioMixGroup[0];
        //audioE.outputAudioMixerGroup = audioMixGroup[0];
        //audioF.outputAudioMixerGroup = audioMixGroup[0];
        //audioFSharp.outputAudioMixerGroup = audioMixGroup[0];
        //audioG.outputAudioMixerGroup = audioMixGroup[0];
        //audioGSharp.outputAudioMixerGroup = audioMixGroup[0];
    }

    // Update is called once per frame
    void Update ()
    {
        MIDIInput();
	}

    void MIDIInput()
    {
        //C note
        if (MidiJack.MidiMaster.GetKeyDown(0, 48) || Input.GetKeyDown(KeyCode.A))
        {
            audioC.Play();
            print("note played");
        }

        if (MidiJack.MidiMaster.GetKeyUp(0, 48) || Input.GetKeyUp(KeyCode.A))
        {
            audioC.Stop();
            print("note played");
        }

        //C# note
        if (MidiJack.MidiMaster.GetKeyDown(0, 49))
        {
            audioCSharp.Play();
            print("note played");
        }

        //D note
        if (MidiJack.MidiMaster.GetKeyDown(0, 50))
        {
            audioDSharp.Play();
            print("note played");
        }

        //D# note
        if (MidiJack.MidiMaster.GetKeyDown(0, 51))
        {
            audioDSharp.Play();
            print("note played");
        }

        //E note
        if (MidiJack.MidiMaster.GetKeyDown(0, 52))
        {
            audioE.Play();
            print("note played");
        }

        //F note
        if (MidiJack.MidiMaster.GetKeyDown(0, 53))
        {
            audioF.Play();
            print("note played");
        }

        //F# note
        if (MidiJack.MidiMaster.GetKeyDown(0, 54))
        {
            audioFSharp.Play();
            print("note played");
        }

        //G note
        if (MidiJack.MidiMaster.GetKeyDown(0, 55))
        {
            audioG.Play();
            print("note played");
        }

        //G# note
        if (MidiJack.MidiMaster.GetKeyDown(0, 56))
        {
            audioGSharp.Play();
            print("note played");
        }

        //A note
        if (MidiJack.MidiMaster.GetKeyDown(0, 57))
        {
            audioA.Play();
            print("note played");
        }

        //A# note
        if (MidiJack.MidiMaster.GetKeyDown(0, 58))
        {
            audioASharp.Play();
            print("note played");
        }

        //B note
        if (MidiJack.MidiMaster.GetKeyDown(0, 59))
        {
            audioB.Play();
            print("note played");
        }
    }
}
