using UnityEngine;
using UnityEngine.UI;

public class AddHealth : HealthBar
{
    public float heal_damage;

    private Image pasek;  
    public Text stateHealth;

    public void Start()
    {
        pasek = HealthBar.FindObjectOfType<Image>(); 
        pasek = healthBarFilling;
        stateHealth.text = (pasek.fillAmount * 100).ToString() + " %";
    }

    public void OnTriggerEnter2D(Collider2D collision) // damage 
    {

        if (collision.tag == "Player")
        {
            AddHealth(heal_damage); // minus or plus damage
            stateHealth.text = (pasek.fillAmount * 100).ToString() + " %";
            Destroy(this.gameObject);

        }
    }
}
