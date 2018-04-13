using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitContinue : MonoBehaviour {

    Image QuitMenu;
    public GameObject Image;
    bool Active = false;

    float time = 0f;

	// Use this for initialization
	void Start () {
        QuitMenu = GameObject.Find("QuitMenu").GetComponent<Image>();
        Image.SetActive(false);
        QuitMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        time += 1 * Time.deltaTime;
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if(time>=300f)
        {
            if(Active==false)
            {
                QuitMenu.enabled = true;
                Image.SetActive(true);
                Active = true;
            }
            
        }
            
    }

    public void QuitGame()
    {
        print("quit");
        Application.Quit();
    }

    public void Continue()
    {
        print("continue");
        QuitMenu.enabled = false;
        Image.SetActive(false);
    }
}
