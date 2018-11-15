using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathWarp : MonoBehaviour
{
    private bool inTrigger;

    // Update is called once per frame
    void Update()
    {
        if (inTrigger)
        {
            SceneManager.LoadScene("Title");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
}
