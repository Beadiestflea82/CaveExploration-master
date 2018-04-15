using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

    private AudioSource AudioPlayer;

    public AudioClip FirstSong;
    public AudioClip SecondSong;
    public AudioClip ThirdSong;

    public bool FirstPattern = false;
    public bool SecondPattern = false;
    public bool ThirdPattern = false;

    bool Fade = false;
    bool FadeStop = false;
    public bool first = true;

    float Volume = 1f;
	// Use this for initialization
	void Start () {
        AudioPlayer = gameObject.GetComponent<AudioSource>();
        
	}
	
	// Update is called once per frame
	void Update () {

        if(Fade)
        {
            Volume -= 0.2f * Time.deltaTime;
            AudioPlayer.volume = Volume;
        }

    }

    public void StartFadeOut()
    {
        StartCoroutine(FadeOut());
    }
    IEnumerator FadeOut()
    {
        Volume = 1f;
        Fade = true;
        yield return new WaitForSeconds(10f);
        AudioPlayer.Stop();
        Fade = false; 
    }
}
