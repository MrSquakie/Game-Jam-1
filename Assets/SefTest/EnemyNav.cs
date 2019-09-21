using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{
    public GameObject player, goal;
    public NavMeshAgent agent;
    /*public Shooting hit;*/
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
    private void OnTriggerExit(Collider player)
    {
        //If player moves away from enemy after colliding, enemy follows
        if (stay == false)
        {
            follow = true;
            agent.isStopped = false;
        }
    }
    void Start()
    {
        stay = false;
        follow = false;
    }
    void Update()
    {
        //Below: Attempt at making enemy follow when hit.
        /*if (hit.transform.name == name)
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