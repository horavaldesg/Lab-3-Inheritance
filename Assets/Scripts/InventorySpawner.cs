using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySpawner : Inventory
{
    public Transform pos1;
    public Transform pos2;
    float y;
    Vector3 pos;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        y = (pos2.position.y - pos1.position.y) / 2;
        pos = new Vector3(transform.position.x, y, transform.position.z);
    }
    public void GetWeapon()
    {
        Debug.Log("Get Weapon");

        int i = Random.Range(0,weapons.Length - 1);
        GameObject weapon = Instantiate(weapons[i]);
        
            weapon.transform.position = pos; 
        
        anim.Play("Take 001");
    }
}
