using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using Microsoft.MixedReality.Toolkit.UI;

public class NextPage : MonoBehaviour
{


    public GameObject[] diagrams;
    public Interactable button3;
    public TextMeshPro title;
    private int counter = -1;

 
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < diagrams.Length; i++)
        {
            diagrams[i].SetActive(false);
        }


        button3.OnClick.AddListener(() => NextDiagram());
    }

    // Update is called once per frame
    void NextDiagram()
    {
        counter++;
        if (counter < diagrams.Length)
        {
            for (int i = 0; i < diagrams.Length; i++)
            {
                diagrams[i].SetActive(false);
            }
            diagrams[counter].SetActive(true);
            title.SetText("Page " + (counter + 1).ToString());
        }
        else
        {
            for (int i = 0; i < diagrams.Length; i++)
            {
                diagrams[i].SetActive(false);
            }
            diagrams[counter % diagrams.Length].SetActive(true);
            title.SetText("Page " + (counter % diagrams.Length + 1).ToString());
        }
    }
}
