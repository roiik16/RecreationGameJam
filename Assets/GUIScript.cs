using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUIScript : MonoBehaviour
{
    public GameObject ImageObject;
    public GameObject TVanim;
    public GameObject spacetext;
    public GameObject watchtvfirst;

    int tv = 0;

    bool atdoor = false;


    void Update ()
    {
        if (atdoor == true && Input.GetButton("Jump"))
        {
            SceneManager.LoadScene("MuseumScene");
            Debug.Log("Press Space bar to go");
        }
    }

    void OnTriggerEnter2D (Collider2D c)
    {
        // Bill trigger
        if (c.tag == "Bill")
        {
            ImageObject.SetActive(true);
            Debug.Log("Bill Triggered");
        }

        //TV trigger
        if (c.tag == "tv" && tv == 0)
        {
            TVanim.SetActive(true);
            Debug.Log("TVAnim Triggered");
            tv = 1;
        }

        //Space text trigger
        if (c.tag == "door" && tv == 0)
        {
            spacetext.SetActive(true);
            watchtvfirst.SetActive(true);
        }
        // Load new scene
        if (c.tag == "door")
       {
            atdoor = true;
            spacetext.SetActive(true);
            Debug.Log("Lets go steal some ideas !!!");
            
       }
    }

    void OnTriggerExit2D(Collider2D c)
    {
        ImageObject.SetActive(false);

        if (c.tag == "tv" && tv == 1)
        {
            TVanim.SetActive(false);
        }

        if (c.tag == "door")
        {
            spacetext.SetActive(false);
            watchtvfirst.SetActive(false);
        }

    }
}