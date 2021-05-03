using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScript : MonoBehaviour
{
    private float countdown;

    // Start is called before the first frame update
    void Start()
    {
        countdown = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if(countdown <= 0) {
            SceneManager.LoadScene("MainMenu");
        }
        
    }
}
