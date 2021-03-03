using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player: MonoBehaviour
{
    public float health;
    public float speed;
    public float damage;
    public float takeDamage(float takenDamage) { return this.health = this.health - takenDamage; }

    public bool isAlive()
    {
        if (health < 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public float getHealth() { return this.health; }
    public virtual void setHealth() {
    }
    
   public virtual void setDamage()
    {

    }
    private void Update()
    {
        if(this.health < 0)
        {
            SceneManager.LoadScene("GameOver");
            Debug.Log("Game Over");
        }
    }



}
