using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraCast : MonoBehaviour {

    public MusicPlayer mp;
    bool switchOnlyOncePerLook = true;
    public bool FadeComplete = false;
    float Volume = 1f;
    bool changeSong = false;
    public bool first = true;
    Image Timer;
    bool timer = false;
	// Use this for initialization
	void Start () {
        Timer = GameObject.Find("Timer").GetComponent<Image>();
        Timer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(timer)
        {
            Timer.fillAmount += 0.23f * Time.deltaTime;
        }

        //Raycast to test if we're looking at a control object
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 10.0f))
        {

            //draw a Ray in the editor UI
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            if (hit.collider.gameObject.tag == "Control1")
            {

                //Hitting the Control 1 object
                //Debug.Log("hit Control 1");


                if(first)
                {
                    StartCoroutine(FadeOut());
                    first = false;
                }
                
                

                //do a time based check here if we want to wait until we've looked at the orb long enough (eg Volume down ?)
                if (FadeComplete)
                {
                    GameObject.FindGameObjectWithTag("Control1").GetComponentInChildren<Renderer>().material.color = GameObject.FindGameObjectWithTag("Control1").GetComponentInChildren<Renderer>().material.color * Mathf.LinearToGammaSpace(100f);
                    //now change the song playing
                    if (switchOnlyOncePerLook)
                    {
                        Volume = 1f;
                        mp.CurrentlyPlaying = MusicPlayer.currentPlaying.first;
                        mp.hasJustChanged = true;
                        switchOnlyOncePerLook = false;
                        FadeComplete = false;

                    }
                }

                
               
            }


            if (hit.collider.gameObject.tag == "Control2")
            {

                //Hitting the Control 1 object
                //Debug.Log("hit Control 2");

                if (first)
                {
                    StartCoroutine(FadeOut());
                    first = false;
                }

                if (FadeComplete)
                {
                    GameObject.FindGameObjectWithTag("Control2").GetComponentInChildren<Renderer>().material.color = GameObject.FindGameObjectWithTag("Control2").GetComponentInChildren<Renderer>().material.color * Mathf.LinearToGammaSpace(100f);
                    //now change the song playing
                    if (switchOnlyOncePerLook)
                    {
                        Volume = 1f;
                        mp.CurrentlyPlaying = MusicPlayer.currentPlaying.second;
                        mp.hasJustChanged = true;
                        switchOnlyOncePerLook = false;
                        FadeComplete = false;
                    }
                }
               

            }


            if (hit.collider.gameObject.tag == "Control3")
            {

                //Hitting the Control 1 object
                //Debug.Log("hit Control 3");

                if (first)
                {
                    StartCoroutine(FadeOut());
                    first = false;
                }

                if (FadeComplete)
                {
                    GameObject.FindGameObjectWithTag("Control3").GetComponentInChildren<Renderer>().material.color = GameObject.FindGameObjectWithTag("Control3").GetComponentInChildren<Renderer>().material.color * Mathf.LinearToGammaSpace(100f);
                    //now change the song playing
                    if (switchOnlyOncePerLook)
                    {
                        Volume = 1f;
                        mp.CurrentlyPlaying = MusicPlayer.currentPlaying.third;
                        mp.hasJustChanged = true;
                        switchOnlyOncePerLook = false;
                        FadeComplete = false;
                    }
                }
               

            }


            //if we're NOT looking at a control orb but our raycast HAS hit something, we can do another switch
            if (hit.collider.gameObject.tag != "Control3" && hit.collider.gameObject.tag != "Control2" && hit.collider.gameObject.tag != "Control1")
            {

                //Debug.Log("Raycasting at something that is NOT a control orb");
                StopAllCoroutines();
                first = true;
                switchOnlyOncePerLook = true;
                FadeComplete = false;
                Volume = 1f;
                GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
                Timer.enabled = false;
            }

        }
        else
        {
            //we're not looking at anything
            //Debug.Log("Raycast is not hitting anything");
            StopAllCoroutines();
            first = true;
            switchOnlyOncePerLook = true;
            FadeComplete = false;
            Volume = 1f;
            GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
            Timer.enabled = false;

        }




    }
    IEnumerator FadeOut()
    {
        timer = true;
        Timer.enabled = true;
        Timer.fillAmount = 0f;
        Volume -= 0.10f ;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
        yield return new WaitForSeconds(.5f);
        
        Volume -= 0.10f ;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
        yield return new WaitForSeconds(.5f);
        
        Volume -= 0.10f ;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
        yield return new WaitForSeconds(.5f);
        
        Volume -= 0.10f ;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
        yield return new WaitForSeconds(.5f);
        
        Volume -= 0.1f ;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
        Volume -= 0.1f;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
        yield return new WaitForSeconds(.5f);
        
        Volume -= 0.1f;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
        yield return new WaitForSeconds(.5f);
        
        Volume -= 0.1f;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
        yield return new WaitForSeconds(.5f);
        
        Volume -= 0.1f;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
        yield return new WaitForSeconds(.5f);
        
        Volume -= 0.1f;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
        
        yield return new WaitForSeconds(.5f);
        
        FadeComplete = true;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().Stop();
        Volume = 1f;
        GameObject.Find("PatternManager").GetComponent<AudioSource>().volume = Volume;
        Timer.enabled = false;
        timer = false;
        
    }
}

