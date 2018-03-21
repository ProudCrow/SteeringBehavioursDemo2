using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour {

	public void carregar1()
	{
		SceneManager.LoadScene ("demo_chasing");
	}

	public void carregar2()
	{
		SceneManager.LoadScene ("demo_scaping2");
	}

	public void carregar0()
	{
		SceneManager.LoadScene ("loader");
	}
}
