using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using Microsoft.MixedReality.Toolkit.UI;

public class minimize : MonoBehaviour
{


    public Interactable minimizeButton;
    public GameObject bigPanel;
    public GameObject littlePanel;

    // Start is called before the first frame update
    void Start()
    {
        minimizeButton.OnClick.AddListener(() => minimizePanel());
        littlePanel.SetActive(false);
    }

    public void minimizePanel()
    {
        
        bigPanel.SetActive(false);
        littlePanel.SetActive(true);
    }
}
