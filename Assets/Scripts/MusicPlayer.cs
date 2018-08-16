using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    public AudioClip firstSong;
    public AudioClip secondSong;
    public AudioClip thirdSong;

    public enum currentPlaying { first,second,third,nothing}
    public currentPlaying CurrentlyPlaying;

    public bool hasJustChanged;

    AudioSource audio;

    GameObject[] Cristals;

	// Use this for initialization
	void Start () {
        Cristals=GameObject.FindGameObjectsWithTag("Cristal");
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	    switch(CurrentlyPlaying)
        {
            case currentPlaying.first:
                if (hasJustChanged)
                {
                    StopRoutinesSecond();
                    StopRoutinesThird();
                    audio.clip = firstSong;
                    audio.Play();
                    GetComponent<BlinkingStone>().CurrentPhase = BlinkingStone.Phase.Reactivate;
                    hasJustChanged = false;
                }

                break;

            case currentPlaying.second:
                if (hasJustChanged)
                {
                    StopRoutinesFirst();
                    StopRoutinesThird();
                    audio.clip = secondSong;
                    audio.Play();
                    GetComponent<Pattern2>().CurrentPhase = Pattern2.Phase.Reactivate;
                    hasJustChanged = false;
                }
                break;

            case currentPlaying.third:
                if (hasJustChanged)
                {
                    StopRoutinesFirst();
                    StopRoutinesSecond();
                    audio.clip = thirdSong;
                    audio.Play();
                    GetComponent<Pattern3>().CurrentPhase = Pattern3.Phase.Reactivate;
                    hasJustChanged = false;
                }

                break;

            case currentPlaying.nothing:


                break;
        }
	}
    void StopRoutinesFirst()
    {
        GetComponent<BlinkingStone>().CurrentPhase = BlinkingStone.Phase.Reset;
        //GetComponent<BlinkingStone>().StopAllCoroutines();
        foreach (GameObject obj in Cristals)
        {
            obj.GetComponentInChildren<Renderer>().material.color = Color.black;
        }
        
        //GetComponent<BlinkingStone>().enabled = false;
    }
    void StopRoutinesSecond()
    {
        GetComponent<Pattern2>().CurrentPhase = Pattern2.Phase.Reset;
        //GetComponent<Pattern2>().StopAllCoroutines();
        foreach (GameObject obj in Cristals)
        {
            obj.GetComponentInChildren<Renderer>().material.color = Color.black;
        }
        //GetComponent<Pattern2>().enabled = false;
    }
    void StopRoutinesThird()
    {
        GetComponent<Pattern3>().CurrentPhase = Pattern3.Phase.Reset;
        //GetComponent<Pattern3>().StopAllCoroutines();
        foreach (GameObject obj in Cristals)
        {
            obj.GetComponentInChildren<Renderer>().material.color = Color.black;
        }
        //GetComponent<Pattern3>().enabled = false;
    }
}
