using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_light : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = gameObject.AddComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
