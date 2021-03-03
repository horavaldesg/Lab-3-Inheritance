using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TakeDamage : Player
{
    public TextMeshProUGUI text;
    public static bool newRound;
    // Start is called before the first frame update
    void Start()
    {
        health = 150;
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()
    {
        if (newRound)
        {
            health = 150;
        }
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
            Debug.Log("Game Over");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            takeDamage(other.GetComponentInParent<Zombie>().damage);
            HealthBar.PlayerHit(other.GetComponentInParent<Zombie>().damage / 150);
            text.SetText(getHealth().ToString());  
        }
    }
}
