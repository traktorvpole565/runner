using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour {

	int VsePelmeshki;

	public Text Balance;

	void Start()
	{

		VsePelmeshki = PlayerPrefs.GetInt("pelmeshki", 0);

	}

	void Update()
    {

		Balance.text = VsePelmeshki.ToString();


	}

	public void Home()
	{

		SceneManager.LoadScene(0);

	}

	public void UpdateBalance()
    {

		VsePelmeshki = PlayerPrefs.GetInt("pelmeshki", 0);

	}

}
