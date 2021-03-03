using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TakeDamage : Player
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        health = 150;
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            takeDamage(other.GetComponentInParent<Zombie>().damage);
            text.SetText(getHealth().ToString());  
        }
    }
}
