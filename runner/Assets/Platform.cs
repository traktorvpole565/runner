using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	public int speed;

	public Vector3 direction;

	void Update()
	{

		transform.position += direction * speed * Time.deltaTime;

	}

	void OnTriggerEnter(Collider other)
	{
		direction *= -1;

	}

}
	
