using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject[] zombies;
    // Start is called before the first frame update
    void Start()
    {
        zombieSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void zombieSpawn()
    {
        int i = Random.Range(0, zombies.Length - 1);

        GameObject zombie = Instantiate(zombies[i]);
        zombie.transform.position = transform.position;
    }
}
