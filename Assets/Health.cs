using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {


    //READ ME//

    /* This is a bunch of methods that allow you to give an object health 
     * 
     * when setting up attach it to the game object you want to have health.
     * 
     * Default max health is 100 can be changed with SetHealthMax()
     * 
     * Health is locked between 0 as min and what ever the max health is set to
     * 
     * User Can be damaged with Damage(float) and healed with Heal(float)
     * 
     * It is recommend to use FullHeal() on start as health is set to zero by default 
     * 
     * you can also just use Heal() if you dont want to the Object to start with full health
     * 
     * GetCurrentHealth() can be used to get the value of f_Health and GetMaxHealth() can be used to get f_max_Health
     * 
     * LockHealth() is internal and will work its self out
     */




    [SerializeField]
    private float f_max_Health = 100;
    [SerializeField]
    private float f_Health = 100;
    //[SerializeField]
    private float f_min_Health = 0;

    //Update
    private void Update()
    {
        LockHealth();
    }

    //Locks health to be between min and max health.
    private void LockHealth()
    {
        if(f_Health < f_min_Health)
        {
            f_Health = f_min_Health;
        }
        if(f_Health > f_max_Health)
        {
            f_Health = f_max_Health;
        }
    }

    //reduces health by input amount
    public void Damage(float input_f_damage_Amount)
    {
        f_Health -= input_f_damage_Amount;
    }

    //Increases health by input amount
    public void Heal(float input_f_heal_Amount)
    {

        f_Health += input_f_heal_Amount;
    }

    //Sets Max health Value to input amount
    public void SetHealthMax(float input_f_max_Health)
    {
        f_max_Health = input_f_max_Health;
    }

    //heals health to max health
    public void FullHeal()
    {
        f_Health = f_max_Health;
    }


    //Gets the Max value the health can be
    public float GetMaxHealth()
    {
        return f_max_Health;
    }

    //Gets the current health Value
    public float GetCurrentHealth()
    {
        return f_Health;
    }


}
