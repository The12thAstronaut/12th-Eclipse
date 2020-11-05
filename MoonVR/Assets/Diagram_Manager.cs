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

    public TextMeshPro diagramLabel;
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        button2.OnClick.AddListener(() => ButtonPressed());


        if (diagramLabel != null)
        {
            diagramLabel.SetText("Diagram Panel");
        }
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
        }
        diagramLabel.SetText("New Diagram");

    }
}


public class Diagram
{
    public string DiagramName;
    public string diagram;
    public Destination diagramDestination;
}
