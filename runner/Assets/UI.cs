using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

	public Text text;

	public GameObject PauseMenu;

	// Update is called once per frame
	void Update () {

		text.text = Player.instance.pelmeshki.ToString();

		if (Player.instance.isFinished) PauseMenu.SetActive(true);

	}

	public void Restart()
	{

		SceneManager.LoadScene(1);

	}

	public void Home()
	{

		SceneManager.LoadScene(0);

	}

}
