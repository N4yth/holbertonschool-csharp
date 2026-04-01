using System;

public enum Modifier {
    Weak,
    Base,
    Strong
}

public delegate float CalculateModifier(float baseValue, Modifier modifier);

public class Player
{
    private bool warningTriggered = false;
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = this.maxHp;
        this.status = "" + name + " is ready to go!";
        HPCheck += CheckStatus; 
    }

    public delegate void CalculateHealth(float amount);

    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine("{0} takes 0 damage!", this.name);
        }
        else
        {
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
            ValidateHP(hp - damage);
        }
    }

    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine("{0} heals 0 HP!", this.name);
        }
        else
        {
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
            ValidateHP(hp + heal);
        }
    }

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }
        else if (modifier == Modifier.Base)
        {
            return baseValue;
        }
        else
        {
            return baseValue * 1.5f;
        }
    }

    public event EventHandler<CurrentHPArgs> HPCheck;

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            Console.WriteLine("{0} is in perfect health!", this.name);
        else if (e.currentHp >= this.maxHp/2 && e.currentHp < this.maxHp)
            Console.WriteLine("{0} is doing well!", this.name);
        else if (e.currentHp >= this.maxHp/4 && e.currentHp < this.maxHp/2)
            Console.WriteLine("{0} isn't doing too great...", this.name);
        else if (e.currentHp > 0 && e.currentHp < this.maxHp/4)
            Console.WriteLine("{0} needs help!", this.name);
        else if (e.currentHp == 0)
            Console.WriteLine("{0} is knocked out!", this.name);
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            var ClassiColor = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Health has reached zero!");
            Console.BackgroundColor = ClassiColor;
            Console.Write("\n");
        }
        else if (e.currentHp <= this.maxHp / 4)
        {
            var ClassiColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Health is low!");
            Console.ForegroundColor = ClassiColor;
            Console.Write("\n");
        }
    }

    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp <= this.maxHp / 4 && this.warningTriggered == false)
        {
            HPCheck += HPValueWarning;
            this.warningTriggered = true;
        }
        HPCheck?.Invoke(this, e);
    }
}


public class CurrentHPArgs : EventArgs
{
    public float currentHp {get;}

    public CurrentHPArgs (float newHp)
    {
        currentHp = newHp;
    }
}
