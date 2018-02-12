////////////////////////////////
/// Práctica: Pinball
/// Alumno /a: Ramón Guardia
/// Curso: 2017/2018
/// Fichero: GameCollision.cs
////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCollision : MonoBehaviour {


    private AudioSource audioSource;
    private float power = 100f;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Storm"))
        {
            // Aumentamos la puntuación
            GameManager.points += GameManager.stormPoints;
            collision.gameObject.GetComponent<AudioSource>().Play();
        }

        if (collision.gameObject.tag.Equals("Vader"))
        {
            GameManager.points += GameManager.vaderPoints;
            collision.gameObject.GetComponent<AudioSource>().Play();
        }

        if (collision.gameObject.tag.Equals("DeadStar"))
        {
            GameManager.points += GameManager.starPoints;
            if (GameManager.shots < GameManager.maxShots)
            {
                GameManager.shots += GameManager.shotPoints;
                collision.gameObject.GetComponent<AudioSource>().Play();
            }
            else
            {
                SceneManager.LoadScene("Final");
            }
        }

        if (collision.gameObject.tag.Equals("BB8")){
            rb.AddForce(power * Vector3.forward);
        }
    }
}
