using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Move : Player
{
    Animator anim;
    public Transform camTransform;
    public Transform gunContainer;
    public GameObject spawnGun;
    public TextMeshProUGUI interact;
    GameObject gun;
    Gun gunObj;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        gun = GameObject.FindGameObjectWithTag("Gun");
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
            if (Physics.Raycast(camTransform.position , camTransform.transform.forward , out hit, 2))
            {
            if (!hit.collider.GetComponent<Zombie>())
            {


                interact.enabled = true;
                InventorySpawner spwn = hit.transform.GetComponent<InventorySpawner>();
                
                if (hit.collider.CompareTag("Box"))
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        
                        spwn.GetWeapon();
                        spawnGun.GetComponent<SpawnGun>().HoldWeapon();
                        
                    }

                }
                if (hit.collider.CompareTag("Gun"))
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {

                        hit.collider.gameObject.transform.position = gunContainer.position;
                        hit.collider.gameObject.transform.rotation = gunContainer.rotation;
                        damage = gun.GetComponent<Gun>().damage;
                        Debug.Log(damage);
                    }

                    
                }
            }
            RaycastHit shootRay;
            if (Physics.Raycast(camTransform.position, camTransform.transform.forward, out shootRay, Mathf.Infinity))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (shootRay.collider.GetComponent<Zombie>())
                    {
                       
                        shootRay.collider.GetComponent<Zombie>().takeDamage(damage);
                    }
                }
                
            }
        }
        else
        {
            interact.enabled = false;
        }

            Debug.DrawRay(camTransform.position , camTransform. transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

        
    }
}
