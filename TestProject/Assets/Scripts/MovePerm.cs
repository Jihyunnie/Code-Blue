using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePerm : MonoBehaviour {
    public Transform targetPosition;
    public GameObject cube;
    private bool inTrigger;

 
    void Update()
    {
        float step;
        step = 12 * Time.deltaTime;
        if (inTrigger)
        {
            cube.transform.position = Vector3.MoveTowards(cube.transform.position, targetPosition.position, step);
        }
    }
    private void OnTriggerEnter()
        {
            inTrigger = true;
        }
}
