using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlat : MonoBehaviour
{
    public Transform leftPosition;
    public Transform rightPosition;
    public GameObject plat;
    private bool inTrigger;
    private int x = 1;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
            float step;
            step = 2 * Time.deltaTime;
            if (x == 1)
            {
                plat.transform.position = Vector3.MoveTowards(plat.transform.position, rightPosition.position, step);
            }
            if (plat.transform.position == rightPosition.position)
            {
                x = 2;
            }
            if (x == 2)
            {
                plat.transform.position = Vector3.MoveTowards(plat.transform.position, leftPosition.position, step);
            }
            if (plat.transform.position == leftPosition.position)
            {
                x = 1;
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
