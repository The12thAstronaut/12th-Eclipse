using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using Microsoft.MixedReality.Toolkit.UI;

public class TaskManager : MonoBehaviour
{

    public TextMeshPro titleLabel;
    public Interactable button1;
    public Interactable backbutton;

    public UnityEvent onChangedTask;
    private Task currentTask;
    private List<Task> tasks = new List<Task>();
    public List<string> taskList = new List<string>();
    public List<string> title = new List<string>();
    private int counter = -1;



    // Start is called before the first frame update
    void Start()
    {


        button1.OnClick.AddListener(() => ButtonPressed());
        backbutton.OnClick.AddListener(() => ReverseTask());
       

        if (titleLabel != null)
        {
            titleLabel.SetText(title[0]);
        }

    }



    public void ButtonPressed()
    {
        counter++;
        Debug.Log("I pressed a button");
        if (counter <= taskList.Count)
        {
            titleLabel.SetText(taskList[counter]);
        }

        else
        {
            titleLabel.SetText(taskList[10]);
            counter = 10;
        }
    }

    public void ReverseTask()
    {
        counter--;
        if (0 <= counter && counter <= taskList.Count)
        {
            titleLabel.SetText(taskList[counter]);
        }

        else if (counter < 0)
        {
            titleLabel.SetText(taskList[0]);
            counter = 0;
        }

        else
        {
            titleLabel.SetText(taskList[10]);
            counter = 10;
        }
    }
}

public class Task
{
    public string taskName;
    public string text;
    public Destination taskDestination;
}
