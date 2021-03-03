using UnityEngine;
using System.Collections;
using UnityEngine.AI;
public class Zombie : Player
{
    GameObject player;
    NavMeshAgent agent;
    Transform target;
    float minDistance = 1;
    public override void setHealth()
    {
        this.health = Random.Range(50, 150);
        base.setHealth();

    }
    public override void setDamage()
    {
        this.damage = Random.Range(20, 30);
        base.setDamage();
    }
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        setHealth();
        setDamage();
    }

    private void Update()
    {
        target = player.transform;
        Vector3 differenceVector = target.position - transform.position;
        if(differenceVector.magnitude > minDistance)
        {
            transform.position = target.transform.position.normalized;

        }
        //else
        //{
        //    agent.destination = agent.transform.position;
        //}
    }
}
