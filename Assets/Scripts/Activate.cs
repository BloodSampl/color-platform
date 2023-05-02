using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject activate;
    public GameObject deActivate;

   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            activate.SetActive(!activate.activeSelf);
            deActivate.SetActive(!deActivate.activeSelf);
        }
    }
}
