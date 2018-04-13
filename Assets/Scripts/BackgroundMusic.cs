using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

    GameObject manager;
    AudioSource Player;
    bool active = false;

	// Use this for initialization
	void Start () {
        manager = GameObject.Find("PatternManager");
        Player = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(manager.GetComponent<AudioSource>()!=null)
        {
            Player.Stop();
        }
        else
        {
            if(active)
            {
                Player.Play();
                active = false;
            }
            
        }
    
	}
}
