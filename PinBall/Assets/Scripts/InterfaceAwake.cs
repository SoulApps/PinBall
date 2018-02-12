////////////////////////////////
/// Práctica: Pinball
/// Alumno /a: Ramón Guardia
/// Curso: 2017/2018
/// Fichero: InterfaceAwake.cs
////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameManager.points = 0;
        GameManager.shots = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        SceneManager.LoadScene("Pinball");
    }
}
