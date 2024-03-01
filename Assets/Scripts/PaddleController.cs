using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
	public KeyCode input;
	public float springPower;

	private HingeJoint hinge;

	private void Start()
  {
    hinge = GetComponent<HingeJoint>();
  }

	private void Update()
  {
    ReadInput();
  }

  private void ReadInput()
  {
    JointSpring jointSpring = hinge.spring;

    if (Input.GetKey(input))
    {
        jointSpring.spring = springPower;
    }
    else
    {
        jointSpring.spring = 0;
    }

    hinge.spring = jointSpring;
  }
}