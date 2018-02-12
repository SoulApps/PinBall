using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCollision : MonoBehaviour {

    private AudioSource audioSource;
    // Use this for initialization
    void Start()
    {

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
        }

        if (collision.gameObject.tag.Equals("DeadStar"))
        {
            GameManager.points += GameManager.starPoints;
            if (GameManager.shots < 10)
            {
                GameManager.shots += GameManager.shotPoints;
            }
            else
            {
                SceneManager.LoadScene("Final");
            }
        }
    }
}
