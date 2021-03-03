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
        this.damage = Random.Range(15, 20);
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
            ScoreText.score += 100;
            Destroy(gameObject);
        }
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.transform.forward, out hit, 2))
        {

            if (hit.collider.CompareTag("Player"))
            {
                anim.SetBool("Attack", true);
            }
            else
            {
                anim.SetBool("Attack", false);
            }


        }
        Debug.DrawRay(transform.position, transform.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

    }
}
