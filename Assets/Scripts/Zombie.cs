using UnityEngine;
using System.Collections;
using UnityEngine.AI;
public class Zombie : Player
{
    GameObject player;
    NavMeshAgent agent;
    Transform target;
    float minDistance = 1;
    Animator anim;
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
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        setHealth();
        setDamage();
    }

    private void Update()
    {
        target = player.transform;
        Vector3 differenceVector = target.position - transform.position;
        if(differenceVector.magnitude > minDistance)
        {
           agent.destination = target.transform.position;
            anim.SetFloat("Speed", agent.speed);

        }
        else
        {
            anim.SetFloat("Speed", agent.speed);
            agent.destination = agent.transform.position;
        }
        if (health <= 0)
        {

            Destroy(gameObject);
        }
    }
}
