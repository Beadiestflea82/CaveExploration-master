using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern2 : MonoBehaviour {

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

    float duration = 5f;
    float t = 0f;

    bool Genereate = false;
    int randomNum = 136;
    // Use this for initialization
    void Start () {
        startTime = Time.time;
        StartCoroutine(Introduction());
    }
	
	// Update is called once per frame
	void Update () {
        if (t < 1)
        {
            t += Time.deltaTime / duration;
        }
        
    }
    IEnumerator Beat()
    {
        if (Genereate)
        {
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), endColorRed * Mathf.LinearToGammaSpace(100f), t);
            randomNum = Random.Range(136, 147);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
            yield return new WaitForSeconds(0.2f);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), endColorRed * Mathf.LinearToGammaSpace(100f), t);
            randomNum = Random.Range(136, 147);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
            yield return new WaitForSeconds(0.1f);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), endColorRed * Mathf.LinearToGammaSpace(100f), t);
            randomNum = Random.Range(136, 147);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
            yield return new WaitForSeconds(0.2f);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), endColorRed * Mathf.LinearToGammaSpace(100f), t);
            randomNum = Random.Range(136, 147);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
            yield return new WaitForSeconds(0.1f);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), endColorRed * Mathf.LinearToGammaSpace(100f), t);
            randomNum = Random.Range(136, 147);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
            yield return new WaitForSeconds(0.1f);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), endColorRed * Mathf.LinearToGammaSpace(100f), t);
            randomNum = Random.Range(136, 147);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
            yield return new WaitForSeconds(0.2f);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), endColorRed * Mathf.LinearToGammaSpace(100f), t);
            randomNum = Random.Range(136, 147);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
            yield return new WaitForSeconds(0.1f);

            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), endColorRed * Mathf.LinearToGammaSpace(100f), t);
            randomNum = Random.Range(136, 147);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
            yield return new WaitForSeconds(0.1f);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), endColorRed * Mathf.LinearToGammaSpace(100f), t);
            randomNum = Random.Range(136, 147);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
            yield return new WaitForSeconds(0.1f);
            GlowingStones[randomNum].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), endColorRed * Mathf.LinearToGammaSpace(100f), t);
            yield return new WaitForSeconds(1f);
            StartCoroutine(Beat());
        }

    }
    IEnumerator Introduction()
    {
        //Right String glow
        yield return new WaitForSeconds(6f);
        GlowingStones[0].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[1].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[2].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[3].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[7].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[8].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[9].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[10].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[11].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[12].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[13].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        //left String glow
        yield return new WaitForSeconds(1.9f);
        GlowingStones[14].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[15].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[16].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[17].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[18].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[19].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[20].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[21].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[0].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[22].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[1].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[23].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[2].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[24].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[3].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[25].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[26].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[27].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[28].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[7].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[29].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[8].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[9].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[10].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.1f);
        GlowingStones[11].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.1f);
        GlowingStones[12].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.1f);
        GlowingStones[13].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.1f);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.1f);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.1f);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.1f);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.1f);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(.1f);


        //Back String glow
        GlowingStones[30].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[31].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[32].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[33].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[34].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[35].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[14].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[15].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[16].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[17].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[18].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[19].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[20].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[21].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[22].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[23].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[24].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[25].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[26].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[27].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[28].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[29].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(1.5f);

        //First three strings fade out
        GlowingStones[30].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[31].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[32].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[33].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[34].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[35].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Second Left String glow
        yield return new WaitForSeconds(0.8f);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[47].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[48].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[49].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[50].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[51].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[52].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[53].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[54].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[55].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[56].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[57].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);




        //Second Back String glow
        yield return new WaitForSeconds(0.2f);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[69].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[70].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[71].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[72].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[47].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[73].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[48].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[74].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[49].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[75].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[50].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[76].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[51].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[77].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[52].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[104].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[53].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[105].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[54].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[106].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[55].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[107].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[56].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[57].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        //Second Right String glow
        yield return new WaitForSeconds(0.4f);
        GlowingStones[78].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[79].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[101].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[69].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[102].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[70].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[103].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[71].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[72].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[73].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[74].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[75].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[76].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[77].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[104].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[105].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[106].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[107].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);


        //Second Strings fade
        yield return new WaitForSeconds(.1f);

        GlowingStones[78].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[79].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[101].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[102].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[103].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);



        //Second Left String glow and right String
        yield return new WaitForSeconds(.1f);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[47].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[48].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[49].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[0].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(0.1f);
        GlowingStones[50].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[1].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[51].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[2].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[52].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[3].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[53].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[54].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[55].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[56].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[7].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[57].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[8].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[9].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[10].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[11].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[12].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[13].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);


        //Second Back String glow and left String

        yield return new WaitForSeconds(0.1f);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[14].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(0.1f);
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[15].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[69].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[16].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[70].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[17].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[71].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[18].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[72].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[19].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[73].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[20].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[74].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[21].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[75].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[22].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[76].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[23].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[77].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[24].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[104].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[25].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[105].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[26].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[106].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[27].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[107].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[28].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[29].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(2.4f);
        //Second Right String and back string

        GlowingStones[30].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[31].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[32].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[78].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(0.05f);
        GlowingStones[33].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[79].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[34].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[35].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[101].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[102].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[103].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(0.05f);

        //Extensions to middle
        GlowingStones[108].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[111].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[122].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[130].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[109].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[112].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[123].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[131].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[110].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[113].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[124].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[132].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[114].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[125].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[133].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[115].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[126].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[134].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[116].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[127].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[135].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[117].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[128].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[118].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[129].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[119].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[120].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[121].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.05f);

        //Arch Middle glow
        GlowingStones[136].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[137].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorRed * Mathf.LinearToGammaSpace(100f), t);

        yield return new WaitForSeconds(1.2f);
        //Arch Middle beat
        Genereate = true;
        StartCoroutine(Beat());

        yield return new WaitForSeconds(1.3f);
        //First Beat
        print("first beat");
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.2f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(3.9f);
        //Second Beat
        print("second beat");
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.2f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(2f);
        //Third Beat
        print("third beat");
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(1.5f);
        //Fourth Beat
        print("fourth beat");
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.2f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.4f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(5.8f);
        //Fifth Beat
        print("fifth beat");
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.2f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.2f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.2f);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(1.1f);

        //Sixth Beat
        print("sixth beat");
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.2f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.5f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);


        yield return new WaitForSeconds(4f);
        Genereate = false;
        //Seventh Beat
        print("seventh beat");
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.2f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.4f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(3.5f);

        //Eighth Beat
        print("eighth beat");
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.2f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.4f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(startColor, endColorYellow * Mathf.LinearToGammaSpace(100f), t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[148].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[149].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[150].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorYellow * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(3f);
        //Right, Left, Back, sec left, sec back, sec right
        GlowingStones[0].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[14].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[30].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[43].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[44].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[61].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[62].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[78].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[1].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[15].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[31].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[45].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[46].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[63].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[64].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[79].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[2].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[16].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[32].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[47].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[65].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[80].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[3].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[17].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[33].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[48].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[66].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[81].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[4].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[18].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[34].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[49].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[67].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[82].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[5].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[19].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[35].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[50].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[68].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[83].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[6].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[20].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[36].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[51].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[69].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[84].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[7].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[21].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[37].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[52].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[70].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[85].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[8].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[22].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[38].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[53].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[71].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[86].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[9].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[23].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[39].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[54].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[72].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[87].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[10].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[24].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[40].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[55].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[73].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[88].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[11].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[25].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[41].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[56].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[74].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[100].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[12].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[26].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[42].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[57].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[75].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[101].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[13].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[27].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[96].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[58].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[76].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[102].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[89].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[28].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[97].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[59].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[77].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[103].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[90].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[29].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[98].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[60].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[104].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[91].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[94].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[99].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[105].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[92].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[95].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[106].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[93].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[107].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        //Extensions to middle
        GlowingStones[108].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[111].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[122].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[130].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[109].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[112].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[123].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[131].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.1f);
        GlowingStones[110].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[113].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[124].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[132].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);


        yield return new WaitForSeconds(2.1f);

        GlowingStones[125].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[133].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(1.8f);

        GlowingStones[126].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[134].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(1.8f);

        GlowingStones[127].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[135].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(1.8f);

        GlowingStones[128].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[114].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(1.8f);

        GlowingStones[129].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        GlowingStones[115].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(1.8f);
        GlowingStones[116].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(1.8f);
        GlowingStones[117].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(1.8f);
        GlowingStones[118].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(1.8f);
        GlowingStones[119].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(1.8f);
        GlowingStones[120].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(1.8f);
        GlowingStones[121].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        yield return new WaitForSeconds(4f);
        //Middle Arch Fade
        GlowingStones[136].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[137].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[138].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[139].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[140].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[141].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[142].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[143].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[144].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[145].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[146].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);
        yield return new WaitForSeconds(0.05f);
        GlowingStones[147].GetComponentInChildren<Renderer>().material.color = Color.Lerp(endColorRed * Mathf.LinearToGammaSpace(100f), startColor, t);

        
        gameObject.GetComponent<Change>().StartFadeOut();
    }


}
