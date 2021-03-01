
public class Player
{
    private string playerName;
    private double playerHealth;
    private double playerDamage;
    private double playerStrength;
    //public Player(string name, double playerHealth, double playerDamage, double playerStrength)
    //{
    //    this.playerName = name;
    //    this.playerHealth = playerHealth;
    //    this.playerDamage = playerDamage;
    //    this.playerStrength = playerStrength;
    //}

    public double getHealth() { return this.playerHealth; }
    public double getStrength() { return this.playerStrength; }
    public string getName() { return this.playerName; }

    public double setHealth(double health) { return this.playerHealth = health; }
    public string setName(string name) { return this.playerName = name; }

    public double attack() { return 0; }
    public double takeDamage(double damage) { return this.playerHealth = this.playerHealth - damage;   }




}
