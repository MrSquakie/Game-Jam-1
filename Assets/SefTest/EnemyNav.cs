using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{
    public GameObject player;
    public GameObject goal;
    public NavMeshAgent agent;
    public Shooting hit; //doesn't work
    private bool follow;
    private void OnTriggerEnter(Collider other)
    {
        //when enemy runs collides with player/castle, enemy stops
        if(player)
        {
            agent.isStopped = true;
        }

        if(goal)
        {
            agent.isStopped = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(player)
        {
            //Attack
        }

        if(goal)
        {
            //Attack
        }
    }
    private void OnTriggerExit(Collider player)
    {
        //if player moves away from enemy after colliding, enemy follows
        follow = true;
        agent.isStopped = false;
    }
    void Update()
    {
        
        /*if (hit)
        {
            follow = true;
        }*/ //doesn't work

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