using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using Microsoft.MixedReality.Toolkit.UI;

public class labels : MonoBehaviour
{

    public Interactable button1;
    public TextMeshPro labelTitle1;
    public TextMeshPro labelTitle2;
    public List<string> label1 = new List<string>();
    public List<string> label2 = new List<string>();
    public int counter;

    void Start()
    {
        button1.OnClick.AddListener(() => ButtonPressed());



    }

    
    public void ButtonPressed()
    {
        counter++;
        Debug.Log("I pressed a button");
        if (counter < label1.Count)
        {
            labelTitle1.SetText(label1[counter]);
            labelTitle2.SetText(label2[counter]);
        }

        else
        {
            labelTitle1.SetText(label1[counter % label1.Count]);
            labelTitle2.SetText(label2[counter % label2.Count]);
            
        }
    }

}
