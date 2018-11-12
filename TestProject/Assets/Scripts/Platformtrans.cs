﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformtrans : MonoBehaviour
{

    public GameObject player;


private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = transform;
        }
    }
private void OnTriggerExit(Collider other)
    {
        player.transform.parent = null;
    }
}
