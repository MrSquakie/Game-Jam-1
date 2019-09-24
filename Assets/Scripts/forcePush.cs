using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcePush : MonoBehaviour
{
	public Rigidbody body;
	private float push = 1000;
	private bool range = false;
	
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r") && range == true)
		{
			Debug.Log("pressed");
			body.AddForce(Vector3.up * push, ForceMode.Impulse);
		}
	}

	
	private void OnTriggerEnter(Collider other)
	{
		body = other.GetComponent<Rigidbody>();
		range = true;

	}
	private void OnTriggerExit(Collider other)
	{
		range = false;
	}
}
