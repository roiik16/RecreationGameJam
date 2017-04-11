using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour
{
    public GameObject ImageObject;
    public GameObject TVanim;

    int tv = 0;

    void OnTriggerEnter2D (Collider2D c)
    {
        if (c.tag == "Bill")
        {
            ImageObject.SetActive(true);
            Debug.Log("Bill Triggered");
        }

        if (c.tag == "tv" && tv == 0)
        {
            TVanim.SetActive(true);
            Debug.Log("TVAnim Triggered");
            tv = 1;
        }

        else
        {
            TVanim.SetActive(false);
        }

       
    }

    void OnTriggerExit2D(Collider2D c)
    {
        ImageObject.SetActive(false);
        TVanim.SetActive(false);
    }
}