using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class crystalVisualizer : MonoBehaviour
{
    public GameObject[] crystals;
    public GameObject petriDish;
    public GameObject microscope;
  
    
    
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
        float dist = Vector3.Distance(microscope.transform.position, petriDish.transform.position);
        Debug.Log(dist);

        if (dist < 0.15)
        
        for (int i = 0; i < crystals.Length; i++)
        {
            crystals[i].SetActive(true);
        }
    }
}
