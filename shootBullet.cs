using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBullet : MonoBehaviour
{
    public GameObject bulletEmitter;
    public GameObject projectile;
    public float bulletSpeed = 10;

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
        if (Input.GetMouseButtonDown(0))
        {
            GameObject temporary_bullet_handler;
            temporary_bullet_handler = Instantiate(projectile, bulletEmitter.transform.position, bulletEmitter.transform.rotation) as GameObject;
            //temporary_bullet_handler.transform.Rotate(Vector3.left * 90);

            Rigidbody temporary_rigidbody;
            temporary_rigidbody = temporary_bullet_handler.GetComponent<Rigidbody>();
            temporary_rigidbody.AddForce(transform.forward * bulletSpeed);

            Destroy(temporary_bullet_handler, 10.0f);



            //GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            // bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);

        }

    }

}
