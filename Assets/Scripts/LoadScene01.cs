using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick_Back01load()
	{
		SceneManager.LoadScene ("01 load");	
	}

	void OnGUI()
	{
		if(GUI.Button (new Rect (20, 230, 200, 200), "Back To 01 load"))
		{
			SceneManager.LoadScene ("01 load");	
		}
	}
}
