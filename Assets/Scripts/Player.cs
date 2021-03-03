using UnityEngine;
using System.Collections;

public class Player: MonoBehaviour
{
    public float health;
    public float damage;

    public float takeDamage(float damage) { return this.health = this.health - damage; }
    public float giveDamage() { return this.damage; }

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
    public virtual void setHealth()
    {
        Debug.Log(this.health);
    }
   public virtual void setDamage()
    {

    }

  
  

}
