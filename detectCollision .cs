using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    public bool enemyEnter = false;
    public GameObject Collider;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                //If the GameObject's name matches the one you suggest, output this message in the console
                Debug.Log("enemy is in the collider");
                Debug.Log(collision.transform.position);
                enemyEnter = true;
            }
             else 
             {
                enemyEnter = false;
             }

        Debug.Log("detect object");
            
        }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("no object detected");
        }
    }
}
