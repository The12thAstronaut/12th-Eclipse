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

    public UnityEvent onChangedTask;
    private Task currentTask;
    private List<Task> tasks = new List<Task>();
    public List<string> taskList = new List<string>();
    public int counter = -1;
    


    // Start is called before the first frame update
    void Start()
    {

        taskList.Add("Connect wire 1 to connector 3");
        taskList.Add("Connect wire 2 to connector 4");
        taskList.Add("Connect wire 3 to connector 5");
        taskList.Add("Connect wire 4 to connector 6");
        taskList.Add("Connect wire 5 to connector 7");
        taskList.Add("Connect wire 6 to connector 8");
        taskList.Add("Connect wire 7 to connector 9");
        taskList.Add("Connect wire 8 to connector 10");
        taskList.Add("Connect wire 9 to connector 1");
        taskList.Add("Connect wire 10 to connector 2");
        taskList.Add("Maintenance Complete");

        button1.OnClick.AddListener(() => ButtonPressed());
        button1.OnClick.AddListener(() => IncrementCount());

        if (titleLabel != null)
        {
            titleLabel.SetText("Beginning Maintenance Task: Connecting Wires to Panel");
        }

    }

    public void IncrementCount()
    {
        Debug.Log(counter++);
    }

    public void ButtonPressed()
    {
        Debug.Log("I pressed a button");
        if (counter <= taskList.Count)
        {
            titleLabel.SetText(taskList[counter]);
        }

        else
        {
            titleLabel.SetText(taskList[10]);
        }
    }
}

public class Task
{
    public string taskName;
    public string text;
    public Destination taskDestination;
}

