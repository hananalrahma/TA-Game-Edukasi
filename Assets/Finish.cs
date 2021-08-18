using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public GameObject completeLevelUI;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ThirdPersonController")
        {
            completeLevelUI.SetActive(true);
        }    
    }
}
