using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public static Player instance { get; private set; }

	private void Awake()
	{
		if (instance == null)
			instance = this;
	}

	public int speed;

	public Vector3 direction;

	Vector3 right = new Vector3(1, 0, 0);

	Vector3 left = new Vector3(-1, 0, 0);

	public int pelmeshki = 0;

	public GameObject salut;

	public bool isFinished = false;

	int VsePelmeshki ;

	void Start()
    {

		VsePelmeshki = PlayerPrefs.GetInt("pelmeshki", 0);

	}

	// Update is called once per frame

	void OnTriggerEnter(Collider other)
    {

		if (other.tag == "Obstacle") isFinished = true;

		if (other.tag == "Finish")
        {

			salut.GetComponent<ParticleSystem>().Play();

		

			isFinished = true;

			VsePelmeshki += pelmeshki;


			PlayerPrefs.SetInt("pelmeshki", VsePelmeshki);

		}


	}

	void Update() {

		if (isFinished) return;
		
		transform.position += direction * speed * Time.deltaTime;



		if (Input.GetKey(KeyCode.D))
			transform.position += right * speed * Time.deltaTime;
				
				
				
		if (Input.GetKey(KeyCode.A))
			transform.position += left * speed * Time.deltaTime;



	}
}
