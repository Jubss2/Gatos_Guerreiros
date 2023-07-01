using System.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controllerat : MonoBehaviour
{
    public static Action AnimFruta;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
            AnimFruta?.Invoke();
        
    
    }
}
