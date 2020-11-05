using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using Microsoft.MixedReality.Toolkit.UI;

public class Diagram_Manager : MonoBehaviour
{

    public Interactable button2;
    public UnityEvent onDiagramView;
    private Diagram currentDiagram;
    public GameObject[] diagrams;
    public GameObject diagramPanel;

    
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        button2.OnClick.AddListener(() => ButtonPressed());


       
    }

    // Update is called once per frame
    void ButtonPressed()
    {
        count++;
        if (count % 2 == 0)
        {
            diagramPanel.SetActive(false);
        }
        else
        {
            diagramPanel.SetActive(true);
            for (int i = 1; i < diagrams.Length; i++)
            {
                diagrams[i].SetActive(false);
            }
            diagrams[0].SetActive(true);
   
        }
        

    }
}


public class Diagram
{
    public string DiagramName;
    public string diagram;
    public Destination diagramDestination;
}
