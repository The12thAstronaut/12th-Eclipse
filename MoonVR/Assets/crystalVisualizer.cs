using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;

public class crystalVisualizer : MonoBehaviour
{
    public GameObject[] crystals;
    public GameObject petriDish;
    
    
    void Start()
    {
        for (int i = 0; i < crystals.Length; i++)
        {
            crystals[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()

    {
        float dist = Vector3.Distance(crystals[0].transform.position, petriDish.transform.position);
        Debug.Log(dist);

        if (dist < 0.065)
        
        for (int i = 0; i < crystals.Length; i++)
        {
            crystals[i].SetActive(true);
        }
    }
}
