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

			PlayerPrefs.SetInt("IsBuying" + hatName, 1);

		}

		

    }

	public void TakeOffHat()
    {

		isHat0n = false;

		PlayerPrefs.SetString("hat", "none");

	}

	public void PutOnHat()
    {

		if (PlayerPrefs.GetString("hat", "none") != "none")
		{
			print("Вы уже в шляпе!");
			return;
		}

		if (IsBuying)
        {

			PlayerPrefs.SetString("hat",hatName);

			isHat0n = true;

		}

    }

	// Use this for initialization
	void Start()
	{

		VsePelmeshki = PlayerPrefs.GetInt("pelmeshki", 0);

		IsBuying = PlayerPrefs.GetInt("IsBuying" + hatName, 0) == 0 ? false : true;

		isHat0n = PlayerPrefs.GetString("hat","none" ) == hatName;
		
	}



	// Update is called once per frame
	void Update () {
		
	}
}
