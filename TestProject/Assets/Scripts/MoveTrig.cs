using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrig : MonoBehaviour {
    public Transform startPosition;
    public Transform targetPosition;
    public GameObject cube;
    private bool inTrigger;

 
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        float step;
        step = 15 * Time.deltaTime;
        if (inTrigger)
        {
            cube.transform.position = Vector3.MoveTowards(cube.transform.position, targetPosition.position, step);
        }
        else
        {
            cube.transform.position = Vector3.MoveTowards(cube.transform.position, startPosition.position, step);
        }
    }
    private void OnTriggerEnter()
        {
            inTrigger = true;
        }
    private void OnTriggerExit()
        {
            inTrigger = false;
        }
}
