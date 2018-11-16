using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changecolobj : MonoBehaviour {
    private bool inTrigger;

    public Material myMaterial;
    // Use this for initialization
    void Start()
    {
        Renderer rend = GetComponent<Renderer>();
        //rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.red);
        //rend.material.shader = Shader.Find("_EmissionColor");
        rend.material.SetColor("_EmissionColor", Color.red);
        //rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);
        
    }

    // Update is called once per frame
    void Update () {
        if (inTrigger)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("_Color");
            rend.material.SetColor("_Color", Color.green);
            rend.material.shader = Shader.Find("_EmissionColor");
            rend.material.SetColor("_EmissionColor", Color.green);
            rend.material.shader = Shader.Find("Specular");
            rend.material.SetColor("_SpecColor", Color.green);
            
        }
    }
    private void OnTriggerEnter()
    {
        inTrigger = true;
    }
}
