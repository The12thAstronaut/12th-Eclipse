using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handPositionLog : MonoBehaviour
{

    public GameObject rightHand;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            rightHand = GameObject.Find("IndexTip Proxy Transform");
            Debug.Log("A pressed");
        }

        if(rightHand != null)
        {
            Debug.Log(rightHand.transform.position);
        }

    }
}
