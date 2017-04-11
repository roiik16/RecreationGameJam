using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour {
    public static float MaximumX;
    public static float MaximumY;
    
    void Start()
    {
        MaximumX = Camera.main.ViewportToWorldPoint(Vector3.one).x;
        MaximumY = Camera.main.ViewportToWorldPoint(Vector3.one).y;
    }
}
