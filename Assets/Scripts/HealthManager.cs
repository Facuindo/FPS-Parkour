using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public UIManager UIManager;
    // Start is called before the first frame update
    void Start()
    {
        UIManager.UpdateHealthText(healthPoints.ToString());
        UIManager = FindObjectOfType<UIManager>();
        UpdateHealth(0);
    }

    public void UpdateHealth(int damageAmount)
    {
        if (healthPoints + damageAmount <= 0)
        {
            Debug.Log("Game over");
            healthPoints = 0;
            UIManager.UpdateHealthText(healthPoints.ToString());
            return;
        }

        healthPoints += damageAmount;
        UIManager.UpdateHealthText(healthPoints.ToString());
    }





}





