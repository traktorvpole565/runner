using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatUI : MonoBehaviour {

	public GameObject buy;

	public GameObject PutOn;

	public GameObject TakeOff;

	Hat hat;

	void Start()
	{

		hat = gameObject.GetComponent<Hat>();

	} 
		// Update is called once per frame
		void Update () {

        if (hat.IsBuying)
        {

			if (hat.isHat0n)
            {

				TakeOff.SetActive(true);

				buy.SetActive(false);

				PutOn.SetActive(false);

			}

            else
            {

				TakeOff.SetActive(false);

				buy.SetActive(false);

				PutOn.SetActive(true);


			}

		}

		else
		{

			TakeOff.SetActive(false);

			buy.SetActive(true);

			PutOn.SetActive(false);


		}

	}
}
