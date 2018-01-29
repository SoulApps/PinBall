using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour {
    // Angulo de posicion en descanso
    public float restPosition = 0f;
    // Angulo de posicion presionado
    public float pressedPosition = 45f;
    // Fuerza de golpe de impacto
    public float hitStrength = 10000f;
    // Fuerza del flipper
    public float flipperDamper = 150f;
    // Nombre de la entrada
    public string inputName;
    HingeJoint hingeJoint;
    void Start () {
        hingeJoint = GetComponent<HingeJoint>();
        hingeJoint.useSpring = true;
	}
	
	// Update is called once per frame
	void Update () {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;
        if (Input.GetAxis(inputName) == 1)
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hingeJoint.spring = spring;
        hingeJoint.useLimits = true;
	}
}
