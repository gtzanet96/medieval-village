﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	/*override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		SceneManager.LoadScene (0);
	}*/
	[SerializeField]
	private string sceneNameToLoad;

	public void LoadByIndex(int sceneIndex)
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene (sceneIndex); 
	}
}
