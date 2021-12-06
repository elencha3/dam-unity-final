using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointsCounter : MonoBehaviour

{
    public GameObject checkpoints;

    int checkPointsCounter = 0;
    public Text counterTxt;

    public Image img;
    public Text congratsTxt, txtVidaScript, txtVida;



    // Start is called before the first frame update
    void Start()
    {
        img.enabled = false;
        congratsTxt.enabled = false;
        txtVidaScript.enabled = true;
        txtVida.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "checkpoints")
        {
            //+1 at counter and show in console and screen
            checkPointsCounter += 1;
            Debug.Log("Contador de checkpoints: " + checkPointsCounter);
           
            counterTxt.text = "" + checkPointsCounter;
        }

        if (collision.gameObject.tag == "lastCheckpoint")
        {
            //Mostrar imagen, y puntuación, mensaje de enhorabuena y quitar las vidas
            this.GetComponent<MovShip>().enabled = false;
            img.enabled = true;
            congratsTxt.enabled = true;
            txtVidaScript.enabled = false;
            txtVida.enabled = false;
        }

    }
}
