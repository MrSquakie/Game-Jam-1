using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjecctonShoot : MonoBehaviour
{
    public Shooting shootingVars;
    // Start is called before the first frame update
    void Start()
    {
        shootingVars = GetComponent<Shooting>();
        shootingVars.Clicked();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
