using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGun : MonoBehaviour
{
    public GameObject[] weapons;
    public Transform gunContainer;
    bool spawned;
    GameObject weapon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawned)
        {
            weapon.transform.position = gunContainer.position;
            weapon.transform.rotation = gunContainer.rotation;
        }
    }
    public void HoldWeapon()
    {
        Debug.Log("Holding Weapon");
        spawned = true;
        int i = Random.Range(0, weapons.Length - 1);
        weapon = Instantiate(weapons[i]);




    }
}
