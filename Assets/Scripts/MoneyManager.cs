using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;
    public TextMeshProUGUI txtMoney;

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
            uiManager.UpdateMoneyText(money.ToString());
            return true;
        }

    }
}
