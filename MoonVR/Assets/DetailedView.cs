using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using Microsoft.MixedReality.Toolkit.UI;

public class DetailedView : MonoBehaviour
{

    public Interactable detailsButton;
    public TextMeshPro detailsText;
    public List<string> details = new List<string>();
    private int counter = -1;

    // Start is called before the first frame update
    void Start()
    {
        detailsButton.OnClick.AddListener(() => showDetails());
    }

    public void showDetails()
    {

    }


}