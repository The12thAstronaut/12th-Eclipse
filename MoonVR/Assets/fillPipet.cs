using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fillPipet : MonoBehaviour
{
    public GameObject filledPipet;
    public GameObject emptyPipet;
    public GameObject petriDish1;
    public GameObject petriDish2;
    public GameObject solution;

    void Start()
    {
        filledPipet.SetActive(false);
        solution.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        float dist = Vector3.Distance(emptyPipet.transform.position, petriDish1.transform.position);
        float nextdist = Vector3.Distance(filledPipet.transform.position, petriDish2.transform.position);
        
        
        if (dist < 0.065)
        {
            filledPipet.SetActive(true);
            emptyPipet.SetActive(false);
        }

        if (nextdist < 0.065)
        {
            filledPipet.SetActive(false);
            emptyPipet.SetActive(true);
            solution.SetActive(true);
        }
    
        
    }
}
