using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Health : MonoBehaviour {



    public GameObject GameOverCanvas;
    public Text TopScore;
    private SaveTopScore script;

    [SerializeField]
    private float f_max_Health = 100;
    [SerializeField]
    private float f_Health = 100;
    //[SerializeField]
    private float f_min_Health = 0;
    private bool b_colliding;

    private void Start()
    {
        GlobalValuesScript.GameIsPLaying = true;
        f_Health = 100f;
        b_colliding = false;
        script = new SaveTopScore();

    }

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.CompareTag("Asteroid") && !b_colliding)
        {
            Damage(Mathf.Round(Random.Range(10, 30)));
            b_colliding = true;
            Destroy(col.gameObject);

        }
    }

    void OnTriggerExit(Collider col)
    {
        b_colliding = false;
    }

    //Update
    private void Update()
    {
       Die();
    }

    private void Die()
    {
        if (f_Health <= f_min_Health)
        {
            GameOverCanvas.SetActive(true);
            script.StoreHighscore(GlobalValuesScript.Score);
            TopScore.text = script.GetTopScore().ToString();

        }
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
        Debug.Log(f_Health);
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
