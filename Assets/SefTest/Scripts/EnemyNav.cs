using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{
    public GameObject player, goal;
    public NavMeshAgent agent;
    //public HealthSystem HealthSystem; //pull damageAmount
    private bool follow, stay;
    private void OnTriggerEnter(Collider other)
    {
        //When enemy triggers goal, it stops and stays.
        Debug.Log("Enemy collided with: "+other.gameObject.tag);
        if(other.gameObject.tag == "Goal")
        {
            agent.isStopped = true;
            stay = true;
        }

        //When enemy triggers player, it stops.
        if(other.gameObject.tag == "Player")
        {
            agent.isStopped = true;
        }
            
    }
    private void OnTriggerExit(Collider other)
    {
        //If player moves away from enemy after colliding, enemy follows
        if (other.gameObject.tag == "Player")
        {
            if (stay == false)
            {
                follow = true;
                agent.isStopped = false;
            }
        }
    }

    void Start()
    {
        stay = false;
        follow = false;
    }
    void Update()
    {
        //Below: (Not Working) when take damage, follow player.
        /*if (damageAmount >= 1)
        {
            Debug.Log("hit");
            follow = true;
        }*/

        if(follow == true)
        {
            //follows player
            Vector3 playerPos = player.transform.position;
            agent.SetDestination(playerPos);
        }
        else
        {
            //moves to castle
            Vector3 goalPos = goal.transform.position;
            agent.SetDestination(goalPos);
        }
        
    }
}