using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestShoot : MonoBehaviour
{
    public Camera playerCam;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Clicked();
    }

    public void Clicked()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = playerCam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));

            Debug.Log("Clicked");
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                print("I'm looking at " + hit.transform.name);

            }
            else
            {
                print("I'm looking at nothing!");
            }

        }



    }
}
