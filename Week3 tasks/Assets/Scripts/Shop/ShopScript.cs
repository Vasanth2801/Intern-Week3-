using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    public Slider  speedSlider,healthSlider;
    public int maxHealth, maxSpeed;

    public int currentHealth, currentSpeed;

    private void Start()
    {
        SetDefs();
    }

    void SetDefs()
    {
        currentHealth = PlayerPrefs.GetInt("health", 0);
        currentSpeed = PlayerPrefs.GetInt("Speed", 0);

        speedSlider.maxValue = maxSpeed;
        healthSlider.maxValue = maxHealth;

        speedSlider.value = currentSpeed;
        healthSlider.value = currentHealth;
    }

    public void buyHealth()
    {
        if(currentHealth < maxHealth)
        {
            currentHealth += 5;
            PlayerPrefs.SetInt("health", currentHealth);
            healthSlider.value = currentHealth;
        }
        else
        {
            Debug.Log("MAX Health");
        }
    }

    public void buySpeed()
    {
        if(currentHealth < maxSpeed)
        {
            currentHealth += 5;
            PlayerPrefs.SetInt("speed", currentSpeed);
            speedSlider.value = currentSpeed;
        }
        else
        {
            Debug.Log("MAX SPEED");
        }
    }
}
