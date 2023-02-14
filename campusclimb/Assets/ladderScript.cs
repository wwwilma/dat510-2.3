using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

public class ladderScript : MonoBehaviour 
{

	public Transform chController;
	bool inside = false;
	public float speedUpDown = 3.2f;
	[SerializeField] private ThirdPersonController chinput;

	void Start()
	{
		//Input = GetComponent<ThirdPersonController>();
		//Debug.Log(Input);
		inside = false;
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Ladder")
		{
			chinput.enabled = false;
			inside = !inside;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if(col.gameObject.tag == "Ladder")
		{
			chinput.enabled = true;
			inside = !inside;
		}
	}

	void Update()
	{
		if(inside == true && Input.GetKey(KeyCode.W))
		{
				chController.transform.position += Vector3.up / speedUpDown;
		}

		if(inside == true && Input.GetKey(KeyCode.S))
		{
				chController.transform.position += Vector3.down / speedUpDown;
		}
	}
}
