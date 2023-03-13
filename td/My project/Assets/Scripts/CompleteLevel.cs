using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour {
//Textos
	public string menuSceneName = "MainMenu";

	public string nextLevel = "Level02";
	public int levelToUnlock = 2;

	public SceneFader sceneFader;

//Opciones de Nivel completo
	public void Continue ()
	{
		PlayerPrefs.SetInt("levelReached", levelToUnlock);
		sceneFader.FadeTo(nextLevel);
	}

	public void Menu ()
	{
		sceneFader.FadeTo(menuSceneName);
	}

}
