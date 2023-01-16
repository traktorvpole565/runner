using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileControllers : MonoBehaviour {

	[SerializeField] string direction;

	[SerializeField] GameObject Floppka;

	public int speed;

	Vector3 right = new Vector3(1, 0, 0);

	Vector3 left = new Vector3(-1, 0, 0);

	public void Moving()
    {

      if(direction == "Right")
        {

			Floppka.transform.position += right * speed * Time.deltaTime;

		}
        else
        {

			Floppka.transform.position += left * speed * Time.deltaTime;

		}


    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
