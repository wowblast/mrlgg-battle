using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Touchscrip : MonoBehaviour {
    public FixedJoystick movejoystick;
    public Fixxedbutton button;
    public FixedTouchField touch;
	public FixedJoystick touch2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var fps = GetComponent<FirstPersonController>();
        fps.RunAxis = movejoystick.inputVector;
        fps.JumpAxis = button.Pressed;
       // Debug.Log(touch.inputVector);
        fps.m_MouseLook.LookAxis = touch2.inputVector;
		
	}
}
