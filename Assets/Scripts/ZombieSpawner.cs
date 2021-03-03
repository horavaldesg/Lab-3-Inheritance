using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject[] zombies;
    GameObject[] spawners;
   
    // Start is called before the first frame update
    void Start()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        zombieSpawn(1);
    }

    // Update is called once per frame
    void Update()
    {

         if(GameObject.FindGameObjectsWithTag("Zombies").Length == 0)
        {
            TakeDamage.newRound = true;
            Debug.Log("No Zombies");
            RoundText.roundText += 1;
            for(int i = 0; i < spawners.Length; i++)
            {
                spawners[i].GetComponent<ZombieSpawner>().zombieSpawn(RoundText.roundText);
            }
           
            

        }
    }
    public void zombieSpawn(int rate)
    {
        TakeDamage.newRound = false;
        int i = Random.Range(0, zombies.Length - 1);
        for(int r = 0; r < rate; r++)
        {
            GameObject zombie = Instantiate(zombies[i]);
            zombie.transform.position = transform.position;
        }
       
    }
}
