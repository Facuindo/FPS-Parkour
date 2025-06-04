using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public bool UpdateMoney (float amount)
    {
        if (money + amount < 0)
        {
            Debug.Log("No te alcanza");
            return false;
        }

        else
        {
            money += amount;
            return true;
          
        }

    }
}
