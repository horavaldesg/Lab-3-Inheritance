using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySpawner : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = (pos2.position.y - pos1.position.y) / 2;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
