using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : MonoBehaviour {

	public bool isHat0n;

	public bool IsBuying;

	public int price;

	[SerializeField]public string hatName;

	int VsePelmeshki;

	public void BuyHat()
    {

		if (VsePelmeshki >= price)
        {

			VsePelmeshki -= price;

			IsBuying = true;

			PlayerPrefs.SetInt("pelmeshki", VsePelmeshki);

			

		}

		

    }

	public void PutOnHat()
    {

		if(IsBuying)
        {

			PlayerPrefs.SetString("hat",hatName);

			isHat0n = true;

		}

    }

	// Use this for initialization
	void Start()
	{

		VsePelmeshki = PlayerPrefs.GetInt("pelmeshki", 0);

		IsBuying = PlayerPrefs.GetInt("IsBuying", 0) == 0 ? false : true;

		isHat0n = PlayerPrefs.GetString("hat","none" ) == hatName;

	}



	// Update is called once per frame
	void Update () {
		
	}
}
