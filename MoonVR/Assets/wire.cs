using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wire : MonoBehaviour
    
{

    public GameObject connector;
    public GameObject cube;
    public GameObject otherCube;
    public float x;
    public float y;
    public float z;
    Vector3 setCube;

    // Start is called before the first frame update
    void Start()
    {
        float x = connector.transform.position[0] - cube.transform.position[0];
        float y = connector.transform.position[1] - cube.transform.position[1];
        float z = connector.transform.position[2] - cube.transform.position[2];
        setCube.Set(x, y, z);
        
    }

    // Update is called once per frame
    void Update()
    {

        cube.transform.Translate(setCube);

  
        
    }
}
