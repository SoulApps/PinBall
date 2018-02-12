////////////////////////////////
/// Práctica: Pinball
/// Alumno /a: Ramón Guardia
/// Curso: 2017/2018
/// Fichero: PointsInterface.cs
////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsInterface : MonoBehaviour {

    public Text points;
    public Text shots;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        points.text = string.Format("Points: {0}", GameManager.points);
        shots.text = string.Format("Shots: {0}", GameManager.shots);
	}
}
