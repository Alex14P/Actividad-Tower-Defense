using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string levelToLoad = "MainLevel";

	public SceneFader sceneFader;
//Opciones  y transciciones
	public void Play ()
	{
		sceneFader.FadeTo(levelToLoad);
	}

	public void Quit ()
	{
		Debug.Log("Exciting...");
		Application.Quit();
	}

}
