using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour
{
    public GameObject ImageObject;

    void OnTriggerEnter2D (Collider2D c)
    {
        if (c.tag == "Bill")
        {
            ImageObject.SetActive(true);
            Debug.Log("TRIGGERED");
        }
    }

    void OnTriggerExit2D(Collider2D c)
    {
        ImageObject.SetActive(false);
    }
}