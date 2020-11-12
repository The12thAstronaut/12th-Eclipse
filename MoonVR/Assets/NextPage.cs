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
    public int counter;
    public bool showFirst;

 
    
    // Start is called before the first frame update
    void Start()

    {
        if (showFirst)
        {
            for (int i = 1; i < diagrams.Length; i++)
            {
                diagrams[i].SetActive(false);
            }

        }
        else
        {
            for (int i = 0; i < diagrams.Length; i++)
            {
                diagrams[i].SetActive(false);
            }
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
