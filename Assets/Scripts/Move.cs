using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Move : Player
{
    Animator anim;
    public TextMeshProUGUI interact;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        float zInput = Input.GetAxisRaw("Horizontal");
        float xInput = Input.GetAxisRaw("Vertical");
        float xSpeed = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        movement += transform.right * xSpeed;
        
        float zSpeed = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        movement += transform.forward * zSpeed;
        anim.SetFloat("Speed", xInput);
        anim.SetFloat("ZSpeed", zInput);
        
        transform.position += new Vector3(movement.x, 0, movement.z);

      
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5))
            {
            interact.enabled = true;
            InventorySpawner spwn = hit.transform.GetComponent<InventorySpawner>();
            if (hit.collider.CompareTag("Box"))
                {
                if (Input.GetKeyDown(KeyCode.E))
                    {
                   
                    spwn.GetWeapon(); 
                    }

                }
        }
        else
        {
            interact.enabled = false;
        }

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

        
    }
}
