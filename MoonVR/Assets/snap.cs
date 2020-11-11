using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snap : MonoBehaviour
{ 

    public GameObject maleConnector;
    public GameObject femaleConnector;



    void Update()
    {
        float dist = Vector3.Distance(maleConnector.transform.position, femaleConnector.transform.position);
        Debug.Log(dist);

        if ((0 < dist  && dist < 0.03) | (dist < 0 && dist > -0.03))
        {
            maleConnector.transform.position = femaleConnector.transform.position;
            maleConnector.transform.rotation = femaleConnector.transform.rotation;
        }


    }


}
