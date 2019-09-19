using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    /// <summary>
    /// NOTE
    /// HealthSystem is meant only for direct interaction with VALUES not the UI. Any UI update should take place in the PlayerHud script.
    /// </summary>
    public float maxHealth, currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        //default values:
          ///<summary>
          ///Player health should default to 100, but in the event we are applying the health system
          ///to a boss or something of the sort we should be able to scale the health value to create
          ///diverse and interesting content.
          /// </summary>
          if (gameObject.tag == "Player")
        {
            maxHealth = 100;
            currentHealth = maxHealth;
        }
          else
        {
            currentHealth = maxHealth; //if not player then set the current health to value defined in inspector
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /// <summary>
    /// Damage() should be called BY ANOTHER SCRIPT, NOT DIRECTLY IN HERE- when the current entity should take damage.
    /// For example in the event they collide with an object that has a means of hit detection (we can use hitboxes or tags to check that)
    /// Parameters that should be passed to the function when it is called is how much damage they should take.
    /// </summary>
    public void Damage(float damageAmount)
    {
        currentHealth -= damageAmount;
    }

}
