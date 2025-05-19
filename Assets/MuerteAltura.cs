using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteAltura : MonoBehaviour
{
    public float yFallHeigth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < yFallHeigth)
        {
            Debug.Log("Te caiste");
            SceneManager.LoadScene("Parkour");
        }
    }
}
