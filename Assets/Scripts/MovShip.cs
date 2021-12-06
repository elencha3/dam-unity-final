using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovShip : MonoBehaviour
{
    //Vars for the speed 
    public float speed, rotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed * Time.time);
        RotateShip();
    }

    void RotateShip()
    {
        //Rotate left
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -1, 0 * rotSpeed * Time.deltaTime);
        }
        //Rotate right
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 1, 0 * rotSpeed * Time.deltaTime);
        }
        //Rotate up
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(-1, 0, 0 * rotSpeed * Time.deltaTime);
        }
        //Rotate down
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(1, 0, 0 * rotSpeed * Time.deltaTime);
        }
    }
}

