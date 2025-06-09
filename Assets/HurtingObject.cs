using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObject : MonoBehaviour
{
    public int damagepoints;
    public HealthManager healthManager;

    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name =="Player")
        {
            damagepoints = damagepoints - 1;
        }
    }

}