using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtBox : MonoBehaviour
{
    public HealthSystem playerHealth;
    void Start()
    {
        
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        print("Player!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        playerHealth = other.gameObject.GetComponentInParent<HealthSystem>();
        if (playerHealth)
        {
            print("Smack");
            playerHealth.Damage(5f);
        }
    }
}
