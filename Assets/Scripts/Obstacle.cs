using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        //Load new scene when collision with obstacle
       if (collision.gameObject.tag == "obstaculos")
        {
            SceneManager.LoadScene("Derrota");
        }
    }
}
