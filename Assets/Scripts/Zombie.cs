using UnityEngine;
using System.Collections;

public class Zombie : Player
{
   
    public override void setHealth()
    {
        this.health = Random.Range(50, 150);
        base.setHealth();

    }
    public override void setDamage()
    {
        this.damage = Random.Range(20, 30);
        base.setDamage();
    }
    private void Start()
    {
        setHealth();
        setDamage();
    }
}
