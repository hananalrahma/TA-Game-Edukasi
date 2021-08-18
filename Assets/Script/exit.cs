using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
   public void doquit()
    {
        Debug.Log("Keluar Game");
        Application.Quit();
    }
}
