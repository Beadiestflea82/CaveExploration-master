using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern3 : MonoBehaviour {
    public GameObject[] GlowingStones;
    public float TimeBetween = 2f;

    public float speed = .5f;
    float startTime;

    public Color startColor;

    public int ColorStateRed;
    public Color endColorRed;

    public int ColorStateBlue;
    public Color endColorBlue;

    public int ColorStateGreen;
    public Color endColorGreen;

    public int ColorStateYellow;
    public Color endColorYellow;

    float duration = 1f;
    float t = 0f;

    bool rightStar = false;
    bool leftStar = false;
    bool backStar = false;
    bool middle = false;

    public enum Phase { Deactivated, Reactivate, Activate, Reset}
    public Phase CurrentPhase;


    void Update () {

        switch (CurrentPhase)
        {
            case Phase.Deactivated:

                break;

            case Phase.Reactivate:
                StartCoroutine(Introduction());
                CurrentPhase = Phase.Activate;
                startTime = Time.time;
                break;

            case Phase.Activate:
                
                break;

            case Phase.Reset:
                StopAllCoroutines();
                rightStar = false;
                leftStar = false;
                backStar = false;
                middle = false;
                CurrentPhase = Phase.Deactivated;
                break;
        }

        if (t < 1)
        {
            t += Time.deltaTime / duration;
        }
    }
    IEnumerator Introduction()
    {
        //Iluminate Up right star
        yield return new WaitForSeconds(.8f);
        GlowingStones[0].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(1.5f);
        GlowingStones[1].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[2].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[3].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(2f);
        GlowingStones[0].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[1].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[2].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[3].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Explode right star
        yield return new WaitForSeconds(2.3f);
        GlowingStones[4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        yield return new WaitForSeconds(.05f);
        GlowingStones[4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[7].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[9].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[8].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[10].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(3.1f);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        //middle Arch light up
        yield return new WaitForSeconds(1.8f);
        GlowingStones[33].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.8f);
        GlowingStones[34].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(1.1f);
        GlowingStones[35].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        
        

        //Iluminate Up left star
        yield return new WaitForSeconds(2.9f);
        GlowingStones[11].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(1.9f);
        GlowingStones[12].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[13].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[14].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[15].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(2f);
        GlowingStones[11].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[12].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[13].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[14].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Explode left star
        yield return new WaitForSeconds(2.4f);
        GlowingStones[15].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.05f);
        GlowingStones[15].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[16].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[18].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[20].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[17].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[19].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[21].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(3.2f);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        //middle Arch light up
        yield return new WaitForSeconds(1.8f);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.8f);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(1.1f);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        

        //Iluminate Up back star
        yield return new WaitForSeconds(2.7f);
        GlowingStones[22].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(2f);
        GlowingStones[23].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[24].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[25].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[26].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(2f);
        GlowingStones[22].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[23].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[24].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[25].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Explode back star
        yield return new WaitForSeconds(2.2f);
        GlowingStones[26].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.05f);
        GlowingStones[26].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[27].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[29].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[31].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[28].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[30].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[32].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(3.2f);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        //middle Arch light up
        yield return new WaitForSeconds(1.8f);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.8f);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(1.1f);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
       

        yield return new WaitForSeconds(4.3f);
        rightStar = true;
        StartCoroutine(RightStarPattern());

        leftStar = true;
        StartCoroutine(LeftStarPattern());

        backStar = true;
        StartCoroutine(BackStarPattern());

        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Middle Arch Up
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);

        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);

        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f), startColor,t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor,t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        

        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);

        middle = true;
        StartCoroutine(MiddleArchGlow());

       

        //middle Arch no light
        yield return new WaitForSeconds(3f);
        GlowingStones[33].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(3f);
        GlowingStones[34].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(3f);
        GlowingStones[35].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(3f);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(3f);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(3f);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(3f);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(3f);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(3f);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(3f);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(3f);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Stop Glowing

        middle = false;
        rightStar = false;
        leftStar = false;
        backStar = false;

        yield return new WaitForSeconds(2f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
       
        
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
       
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f), startColor,t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        yield return new WaitForSeconds(.4f);

        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);   
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);

        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);

        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);

        yield return new WaitForSeconds(.4f);

        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);


        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(2.5f);

        //BackStar stop glowing
        GlowingStones[32].GetComponentInChildren<Renderer>().material.color = Color.Lerp( endColorRed * Mathf.LinearToGammaSpace(100f),startColor, t);
        GlowingStones[28].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[30].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[27].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[29].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[31].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[26].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(2.5f);

        //LeftStar stop glowing
        GlowingStones[21].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[19].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[17].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[20].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[18].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[16].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.5f);
        GlowingStones[15].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(3.6f);

        //RightStar stop glowing
        GlowingStones[10].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[8].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(1.8f);
        GlowingStones[9].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[7].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(1f);
        GlowingStones[4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        //gameObject.GetComponent<Change>().StartFadeOut();

    }

    IEnumerator RightStarPattern()
    {
        yield return new WaitForSeconds(.2f);
        GlowingStones[4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[7].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[9].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[8].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[10].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.2f);

        GlowingStones[5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[7].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[9].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.2f);

        GlowingStones[6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[8].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[10].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        if (rightStar)
        {
            StartCoroutine(RightStarPattern());
        }
    }
    IEnumerator LeftStarPattern()
    {
        yield return new WaitForSeconds(.2f);
        GlowingStones[15].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[16].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[18].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[20].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[17].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[19].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[21].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.2f);
        GlowingStones[16].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[18].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[20].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.2f);
        GlowingStones[17].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[19].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[21].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);


        if (leftStar)
        {
            StartCoroutine(LeftStarPattern());
        }
    }
    IEnumerator BackStarPattern()
    {
        yield return new WaitForSeconds(.2f);
        GlowingStones[26].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[27].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[29].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[31].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[28].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[30].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[32].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.2f);
        GlowingStones[27].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[29].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[31].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.2f);
        GlowingStones[28].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[30].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[32].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

       
        if (backStar)
        {
            StartCoroutine(BackStarPattern());
        }
    }
    IEnumerator MiddleArchGlow()
    {
        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        if(middle)
        {
            StartCoroutine(MiddleArchGlow());
        }
    }
}
