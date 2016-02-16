using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name)
	{
		Debug.Log("Level requested: " + name);
		Application.LoadLevel(name);
	}

	public void QuitRequest()
	{
		Debug.Log("End Requested");
		Application.Quit();
	}
	

}
