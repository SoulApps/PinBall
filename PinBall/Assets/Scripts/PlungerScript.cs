////////////////////////////////
/// Práctica: Pinball
/// Alumno /a: Ramón Guardia
/// Curso: 2017/2018
/// Fichero: PlungerScript.cs
////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerScript : MonoBehaviour {
    public float maxPower = 100f;
    public Slider powerSlider;

    float power;
    List<Rigidbody> ballList;
    bool ballReady;
    public GameObject ball;
    private float posX, posY, posZ;

	// Use this for initialization
	void Start () {
        powerSlider.minValue = 0;
        powerSlider.maxValue = maxPower;
        ballList = new List<Rigidbody>();
        posX = ball.transform.position.x;
        posY = ball.transform.position.y;
        posZ = ball.transform.position.z;

    }
	
	// Update is called once per frame
	void Update () {
        if (ballReady)
        {
            powerSlider.gameObject.SetActive(true);
        }
        else
        {
            powerSlider.gameObject.SetActive(false);
        }

        powerSlider.value = power;

        if(ballList.Count > 0)
        {
            ballReady = true;
            if (Input.GetKey(KeyCode.Space))
            {
                if (power < maxPower) {
                    power += 50 * Time.deltaTime;
                }
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                foreach (Rigidbody r in ballList)
                {
                    r.AddForce(power * Vector3.forward);
                }
            }
        } 
        else
        {
            ballReady = false;
            power = 0f;
        }
        
        if(ball.transform.position.y < -10)
        {
            ballReady = true;
            ball.transform.position = new Vector3(posX, posY, posZ);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            power = 0f;
        }
    }
}
