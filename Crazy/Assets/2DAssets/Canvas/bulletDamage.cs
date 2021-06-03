using UnityEngine;
using UnityEngine.UI;

public class bulletDamage : MonoBehaviour
{
    public float damage = 0.1f;
    private Image pasek;
    public Text stateHealth;
    public Image healthBarFilling;

    public Transform startPoint;

    //public Text livesText; // nowe

    //private int numberOfLives;

    public void Start()
    {
        pasek = HealthBar.FindObjectOfType<Image>(); //gorny pasek
        pasek = healthBarFilling;
        stateHealth.text = ("Health: " + pasek.fillAmount * 100).ToString() + " %";
    }

    //public void OnChangePlayerLives(int numLives)
    //{
    //    string livesMessage = "Lives: " + numLives;
    //    livesText.text = livesMessage;
    //}


    private void OnTriggerEnter2D(Collider2D collision) // zabija gracza
    {
        if (collision.tag == "enemy")
        {
            //Debug.Log("trafiony");
            MinusHealth(damage);
            
            stateHealth.text = ("Health: " + System.Math.Round(pasek.fillAmount * 100)).ToString() + " %";


            if ((pasek.fillAmount * 100) < 2)
            {
                this.transform.position = startPoint.position; // restart gracza
                pasek.fillAmount = 1;
                stateHealth.text = ("Health: " + pasek.fillAmount * 100).ToString() + " %";

                //zmniejszenie ilosci zycia o 1
                //print(livesText.text + " - ilosc zycia string");
                //numberOfLives = int.Parse(livesText.text.Substring(7));
                //print(numberOfLives + " - ilosc zycia int");               
                //livesText.text = "Lives: " + (numberOfLives - 1).ToString();
            }
        }
        if (collision.tag == "knight")
        {
            //Debug.Log("trafiony");
            MinusHealth(damage);
            stateHealth.text = (pasek.fillAmount * 100).ToString() + " %";
            if ((pasek.fillAmount * 100) < 2)
            {
                this.transform.position = startPoint.position; // restart gracza
                pasek.fillAmount = 1;
                stateHealth.text = ("Health: " + pasek.fillAmount * 100).ToString() + " %";

                //zmniejszenie ilosci zycia o 1
                //print(livesText.text + " - ilosc zycia string");
                //numberOfLives = int.Parse(livesText.text.Substring(7));
                //print(numberOfLives + " - ilosc zycia int");               
                //livesText.text = "Lives: " + (numberOfLives - 1).ToString();
            }
        }
    }

    public void MinusHealth(float value)
    {
        healthBarFilling.fillAmount -= value;
    }
}
