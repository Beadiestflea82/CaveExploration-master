using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour {

    //When the mouse hovers over the GameObject, it turns to this color (red)
    Color m_MouseOverColor = Color.blue;
    //This stores the GameObject’s original color
    Color m_OriginalColor;
    //Get the GameObject’s mesh renderer to access the GameObject’s material and color
    MeshRenderer m_Renderer;

    float power = 0f;
    bool mouseover = false;

    public GameObject PatternManager;

    public int ID=1;
    bool pattern1playing = false;
    bool pattern2playing = false;
    bool pattern3playing = false;

    void Start()
    {
        //Fetch the mesh renderer component from the GameObject
        m_Renderer = GetComponent<MeshRenderer>();
        //Fetch the original color of the GameObject
        m_OriginalColor = m_Renderer.material.color;
    }
    private void Update()
    {
        if(mouseover)
        {
            power += 20f * Time.deltaTime;
            
        }
    }
    void OnMouseOver()
    {
        //Change the color of the GameObject to red when the mouse is over GameObject
        m_Renderer.material.color = m_OriginalColor * Mathf.LinearToGammaSpace(power);
        mouseover = true;
    }

    void OnMouseExit()
    {
        mouseover = false;
        //Reset the color of the GameObject back to normal
        m_Renderer.material.color = m_OriginalColor;
    }
}
