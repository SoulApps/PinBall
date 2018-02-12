////////////////////////////////
/// Práctica: Pinball
/// Alumno /a: Ramón Guardia
/// Curso: 2017/2018
/// Fichero: InterfaceFinal.cs
////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InterfaceFinal : MonoBehaviour {

    public Text textThrown;
    public Text textDestroyed;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        SceneManager.LoadScene("Awake");
    }
}
