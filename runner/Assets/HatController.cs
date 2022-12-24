using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatController : MonoBehaviour {

	void Start () {

		string Hatname = PlayerPrefs.GetString("hat", "none");

		if (Hatname != "none")

			GameObject.Find("Player/Hats/"+Hatname).SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
