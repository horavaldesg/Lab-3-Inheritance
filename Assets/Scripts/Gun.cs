using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    public string name;
    public int ammoSize;
    public int ammo;
    public float damage;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        
    }
}
