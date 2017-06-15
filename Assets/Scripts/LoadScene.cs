using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public string sceneAssetbundle;
	public string sceneName;

	// Use this for initialization
	void Start () 
	{
		sceneAssetbundle = "scene.assetbundle";
		sceneName = "01";
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator Load()
	{
		Caching.CleanCache ();

		//window
		//string path = "file://" + Application.dataPath + "/StreamingAssets/" + sceneAssetbundle;
		//android
		//string path = "jar:file://" + Application.dataPath + "!/assets/" + sceneAssetbundle;
		//WebGL
							
		string path = Application.dataPath + "/StreamingAssets/" + sceneAssetbundle;


//		if (!www.isDone) 
//		{
			Debug.Log ("第一次下载！！");

			WWW www = WWW.LoadFromCacheOrDownload (path, 0);
			yield return www;

//			if (www.error == null) {
				AssetBundle ab = www.assetBundle;
				ab = www.assetBundle;
				AsyncOperation async = SceneManager.LoadSceneAsync (sceneName);
				yield return async;
//			}
//			else 
//			{
//				Debug.Log (www.error);
//			}
//		} 
//		else 
//		{
//			Debug.Log ("已经下载过！！");
//			AsyncOperation async = SceneManager.LoadSceneAsync (sceneName);
//			yield return async;
//		}
	}

	void OnGUI()
	{
		if(GUI.Button (new Rect (20, 230, 200, 200), "Load scene.assetbundle"))
		{
			StartCoroutine (Load());
		}
	}
}
