using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingStone : MonoBehaviour {


    public GameObject[] GlowingStones;
    public GameObject currentStone;
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

    bool blueStones = false;
    bool redStones = false;
    bool greenStones = false;
    bool yellowStones = false;

    float duration = 5f;
    float t = 0f;


    public bool ArchMiddleStonesGlow = false;
    bool ArchBackStonesGlow = false;
    bool ArchLeftStonesGlow = false;
    bool ArchRightStonesGlow = false;

    bool LeftShimmer = false;
    bool RightShimmer = false;
    bool BackShimmer = false;
    bool stop = false;
    // Use this for initialization
    void Start()
    {
        
        startTime = Time.time;
        StartCoroutine(ColorPattern());
        GlowingStones[0].GetComponentInChildren<Renderer>().material.color = startColor;
    }

    // Update is called once per frame
    void Update()
    {
        currentStone = GetComponent<BlinkingStone>().currentStone;

        if (t < 1)
        {
            t += Time.deltaTime / duration;
        }
        if (LeftShimmer)
        {
            StartCoroutine(Flickering());
        }
        if (RightShimmer)
        {
            StartCoroutine(Flickering2());
        }
        if (BackShimmer)
        {
            StartCoroutine(Flickering3());
        }
        if (ArchLeftStonesGlow)
        {
            GlowingStones[107].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[108].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[109].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[110].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[111].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[112].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[113].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[114].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[115].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[116].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[117].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[118].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[119].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[120].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);

        }
        else
        {
            if (stop)
            {
                GlowingStones[107].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[108].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[109].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[110].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[111].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[112].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[113].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[114].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[115].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[116].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[117].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[118].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[119].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[120].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
            }
            else
            {


            }
        }
        if (ArchRightStonesGlow)
        {
            GlowingStones[121].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[122].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[123].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[124].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[125].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[126].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[127].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[128].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[129].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[130].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[131].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[132].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[133].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[134].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[135].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[136].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[137].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);

        }
        else
        {
            if (stop)
            {
                GlowingStones[121].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[122].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[123].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[124].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[125].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[126].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[127].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[128].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[129].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[130].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[131].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[132].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[133].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[134].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[135].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[136].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[137].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
            }
            else
            {


            }
        }
        if (ArchMiddleStonesGlow)
        {
            GlowingStones[0].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[1].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[2].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[3].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(30f), t);
            GlowingStones[5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(30f), t);
            GlowingStones[6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(30f), t);
            GlowingStones[7].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(30f), t);
            GlowingStones[8].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(30f), t);
            GlowingStones[9].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(30f), t);
            GlowingStones[10].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(30f), t);
            GlowingStones[11].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(30f), t);
            GlowingStones[12].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(30f), t);

        }
        else
        {
            if (stop)
            {
                GlowingStones[0].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[1].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[2].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[3].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[7].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[8].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[9].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[10].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[11].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[12].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
            }
            else
            {

            }

        }
        if (ArchBackStonesGlow)
        {
            GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[101].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[102].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[103].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[104].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[105].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
            GlowingStones[106].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        }
        else
        {
            if (stop)
            {
                GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[101].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[102].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[103].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[104].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[105].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
                GlowingStones[106].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
            }
            else
            {

            }

        }
        if (redStones)
        {
            switch (ColorStateRed)
            {
                case 1:
                    currentStone.GetComponent<Renderer>().material.color = startColor;
                    break;
                case 2:
                    currentStone.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);//(Time.time - startTime)* speed);
                    break;
                case 3:
                    currentStone.GetComponent<Renderer>().material.color = endColorRed;
                    break;
                case 4:
                    currentStone.GetComponent<Renderer>().material.color = Color.Lerp(endColorRed, startColor, t);//(Time.time - 2) * speed);
                    break;
            }


        }
        if (blueStones)
        {
            switch (ColorStateBlue)
            {
                case 1:
                    currentStone.GetComponent<Renderer>().material.color = startColor;
                    break;
                case 2:
                    currentStone.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColorBlue, t);//(Time.time - 4) * speed);
                    break;
                case 3:
                    currentStone.GetComponent<Renderer>().material.color = endColorBlue;
                    break;
                case 4:
                    currentStone.GetComponent<Renderer>().material.color = Color.Lerp(endColorBlue, startColor, t);//(Time.time - 6) * speed);
                    break;
            }


        }
        if (greenStones)
        {
            switch (ColorStateGreen)
            {
                case 1:
                    currentStone.GetComponent<Renderer>().material.color = startColor;
                    break;
                case 2:
                    currentStone.GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen, t);//(Time.time - 8) * speed);
                    break;
                case 3:
                    currentStone.GetComponent<Renderer>().material.color = endColorGreen;
                    break;
                case 4:
                    currentStone.GetComponent<Renderer>().material.color = Color.Lerp(endColorGreen, startColor, t);//(Time.time - 10) * speed);
                    break;
            }


        }
        if (yellowStones)
        {
            switch (ColorStateYellow)
            {
                case 1:
                    currentStone.GetComponent<Renderer>().material.color = startColor;
                    break;
                case 2:
                    currentStone.GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColorYellow, t);//(Time.time - 12) * speed);
                    break;
                case 3:
                    currentStone.GetComponent<Renderer>().material.color = endColorYellow;
                    break;
                case 4:
                    currentStone.GetComponent<Renderer>().material.color = Color.Lerp(endColorYellow, startColor, t);//(Time.time - 14) * speed);
                    break;
            }

        }

    }

    IEnumerator Flickering()
    {
        LeftShimmer = false;
        GlowingStones[107].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[108].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[109].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[110].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[111].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[112].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[113].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[114].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[115].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[116].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[117].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[118].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[119].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[120].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.8f);

        int num = Random.Range(107, 120);
        GlowingStones[num].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        int num2 = Random.Range(107, 120);
        GlowingStones[num2].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.8f);

        int num3 = Random.Range(107, 120);
        GlowingStones[num3].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        int num4 = Random.Range(107, 120);
        GlowingStones[num4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);


        yield return new WaitForSeconds(.8f);

        int num5 = Random.Range(107, 120);
        GlowingStones[num5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        int num6 = Random.Range(107, 120);
        GlowingStones[num6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);

        if (ArchBackStonesGlow == false)
        {
            StartCoroutine(Flickering());
        }

    }
    IEnumerator Flickering2()
    {
        RightShimmer = false;
        GlowingStones[121].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[122].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[123].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[124].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[125].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[126].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[127].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[128].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[129].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[130].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[131].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[132].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[133].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[134].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[135].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[136].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[137].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.8f);

        int num = Random.Range(121, 137);
        GlowingStones[num].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        int num2 = Random.Range(121, 137);
        GlowingStones[num2].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.8f);

        int num3 = Random.Range(121, 137);
        GlowingStones[num3].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        int num4 = Random.Range(121, 137);
        GlowingStones[num4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);


        yield return new WaitForSeconds(.8f);

        int num5 = Random.Range(121, 137);
        GlowingStones[num5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        int num6 = Random.Range(121, 137);
        GlowingStones[num6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);

        if (ArchBackStonesGlow == false)
        {
            StartCoroutine(Flickering2());
        }

    }
    IEnumerator Flickering3()
    {
        BackShimmer = false;
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[101].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[102].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[103].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[104].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[105].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[106].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);


        yield return new WaitForSeconds(.8f);

        int num = Random.Range(91, 106);
        GlowingStones[num].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        int num2 = Random.Range(91, 106);
        GlowingStones[num2].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.8f);

        int num3 = Random.Range(91, 106);
        GlowingStones[num3].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        int num4 = Random.Range(91, 106);
        GlowingStones[num4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);


        yield return new WaitForSeconds(.8f);

        int num5 = Random.Range(91, 106);
        GlowingStones[num5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        int num6 = Random.Range(91, 106);
        GlowingStones[num6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), endColorGreen * Mathf.LinearToGammaSpace(100f), t);

        if (ArchBackStonesGlow == false)
        {
            StartCoroutine(Flickering3());
        }

    }
    IEnumerator ColorPattern()
    {
        yield return new WaitForSeconds(1);
        ArchMiddleStonesGlow = true;
        yield return new WaitForSeconds(6);
        ArchMiddleStonesGlow = false;
        stop = true;
        yield return new WaitForSeconds(.1f);
        ArchMiddleStonesGlow = true;

        yield return new WaitForSeconds(.3f);
        //ArchMiddleStonesGlow = false;

        GlowingStones[13].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[13].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[14].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[14].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[15].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[15].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[16].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[16].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[17].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[69].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[17].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[69].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[18].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[70].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[18].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[70].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[19].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[71].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[19].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[71].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[20].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[72].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[20].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[72].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[21].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[73].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[21].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[73].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[22].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[47].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[74].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[22].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[47].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[74].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[23].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[48].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[75].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[23].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[48].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[75].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[24].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[49].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[76].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[24].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[49].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[76].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[25].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[50].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[77].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[25].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[50].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[77].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[26].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[51].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[78].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[26].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[51].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[78].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[27].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[52].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[79].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[27].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[52].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[79].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[28].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[53].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[28].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[53].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[29].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[54].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[29].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[54].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[30].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[55].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[30].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[55].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[31].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[56].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[31].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[56].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[32].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[57].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[32].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[57].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[33].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[33].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[34].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[34].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[35].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[35].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        ArchBackStonesGlow = true;



        yield return new WaitForSeconds(.4f);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        ArchLeftStonesGlow = true;



        yield return new WaitForSeconds(.4f);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorGreen * Mathf.LinearToGammaSpace(100f), t);
        //yield return new WaitForSeconds(.2f);
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorGreen * Mathf.LinearToGammaSpace(100f), startColor, t);
        ArchRightStonesGlow = true;
        yield return new WaitForSeconds(.6f);




        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //Left Arch Up
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue, startColor * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue, startColor * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue, startColor * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue, startColor * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue, startColor * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);


        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);


        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);


        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);


        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue, startColor * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue, startColor * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        print("routine starting");
        yield return new WaitForSeconds(.4f);

        KeepGlowing();
        yield return new WaitForSeconds(.4f);

        FadeGlowing();

        yield return new WaitForSeconds(.4f);

        KeepGlowing();

        yield return new WaitForSeconds(.4f);

        FadeGlowing();

        yield return new WaitForSeconds(.4f);

        KeepGlowing();

        yield return new WaitForSeconds(.4f);

        FadeGlowing();

        yield return new WaitForSeconds(.4f);

        KeepGlowing();

        yield return new WaitForSeconds(.4f);

        FadeGlowing();

        yield return new WaitForSeconds(.4f);

        KeepGlowing();

        yield return new WaitForSeconds(.4f);

        FadeGlowing();

        yield return new WaitForSeconds(.4f);


        KeepGlowing();

        yield return new WaitForSeconds(.4f);

        FadeGlowing();

        yield return new WaitForSeconds(.4f);

        KeepGlowing();

        yield return new WaitForSeconds(.4f);

        FadeGlowing();

        yield return new WaitForSeconds(.4f);

        KeepGlowing();

        yield return new WaitForSeconds(.4f);

        FadeGlowing();

        yield return new WaitForSeconds(.4f);

        KeepGlowing();

        yield return new WaitForSeconds(.4f);

        FadeGlowing();

        yield return new WaitForSeconds(.4f);

        KeepGlowing();

        yield return new WaitForSeconds(.4f);

        FadeGlowing();

        


        ArchLeftStonesGlow = false;
        stop = false;
        ArchBackStonesGlow = false;
        ArchRightStonesGlow = false;
        RightShimmer = true;
        BackShimmer = true;
        LeftShimmer = true;

        //FillIn();

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        FillOut();
        //Left Arch Up

        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up

        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up

        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        FillIn();
        //Left Arch Up

        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up

        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up

        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(.4f);

        FillOut();
        //Left Arch Up

        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up


        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up


        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        FillIn();
        //Left Arch Up


        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up


        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up


        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();

        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();

        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();

        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);
        FillOut();

        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);
        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

        FillIn();

        yield return new WaitForSeconds(.4f);

        FillOut();
        yield return new WaitForSeconds(.4f);

       

        //BackToRightArch
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch

        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch

        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch

        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch


        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch


        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch


        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch



        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch



        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch



        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch



        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch



        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch



        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch




        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch




        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch




        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //BackToRightArch




        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //RightToLeftArch




        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch




        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);



        //RightToLeftArch


        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch


        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);



        //RightToLeftArch

        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch

        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);



        //RightToLeftArch


        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch



        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);



        //RightToLeftArch


        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch


        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //LeftToBackArch


        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //LeftToBackArch

        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //LeftToBackArch

        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //LeftToBackArch


        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(.4f);

        //LeftToBackArch


        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        ArchLeftStonesGlow = true;
        ArchBackStonesGlow = true;
        ArchRightStonesGlow = true;

        yield return new WaitForSeconds(1.6f);

        ArchBackStonesGlow = false;
        stop = true;

        yield return new WaitForSeconds(2f);

        ArchLeftStonesGlow = false;

        yield return new WaitForSeconds(1.7f);

        ArchRightStonesGlow = false;

        yield return new WaitForSeconds(4f);

        ArchMiddleStonesGlow = false;

        
        gameObject.GetComponent<Change>().StartFadeOut();

    }

    void FillIn()
    {
        //BackToRightArch
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);


        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
    }

    void FillOut()
    {
        //BackToRightArch


        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);


        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
    }

    void KeepGlowing()
    {

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //RightToLeftArch
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //LeftToBackArch
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
    }

    void FadeGlowing()
    {

        //BackToRightArch
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[151].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //RightToLeftArch
        GlowingStones[152].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[153].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[155].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[154].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[156].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[157].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[158].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[159].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[160].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[161].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[162].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[163].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[164].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[165].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[166].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[167].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[168].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[169].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[170].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[171].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //LeftToBackArch
        GlowingStones[173].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[172].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[175].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[174].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[177].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[176].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[179].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[178].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[181].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[180].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[183].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[182].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[185].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[184].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[187].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[186].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[189].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[188].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[191].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[190].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[193].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[192].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue, startColor, t);
        GlowingStones[195].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue, t);
        GlowingStones[194].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[197].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[196].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[199].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[198].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[201].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[200].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[203].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[202].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Left Arch Up
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Right Arch Up
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);

        //Back Arch Up
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorBlue * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorBlue * Mathf.LinearToGammaSpace(100f), t);


    }
}
