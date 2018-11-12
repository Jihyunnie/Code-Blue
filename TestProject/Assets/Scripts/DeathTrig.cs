using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrig : MonoBehaviour {
    public GameObject spoint;
    public GameObject player;

private void OnTriggerEnter()
    {
        player.transform.position = spoint.transform.position;
        }
    }

