using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using Microsoft.MixedReality.Toolkit.UI;
public class maximize : MonoBehaviour
{

    public Interactable maximizeButton;
    public GameObject bigPanel;
    public GameObject littlePanel;

    // Start is called before the first frame update
    void Start()
    {
        maximizeButton.OnClick.AddListener(() => maximizePanel());
        bigPanel.SetActive(false);
    }

    // Update is called once per frame
    public void maximizePanel()
    {
        littlePanel.SetActive(false);
        bigPanel.SetActive(true);
        
    }
}

