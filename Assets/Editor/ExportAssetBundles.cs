using UnityEngine;
using System.Collections;
using UnityEditor;

public class ExportAssetBundles : MonoBehaviour {

	[MenuItem("Custom Editor/Buile AssetBunldes")]
	static void CreateAssetBunldesMain()
	{
		//BuildPipeline.BuildAssetBundles ("Assets/SteamingAssets");
		BuildPipeline.BuildAssetBundles("Assets/StreamingAssets", BuildAssetBundleOptions.None, BuildTarget.WebGL);
	
		if (BuildPipeline.BuildAssetBundles ("Assets/StreamingAssets", BuildAssetBundleOptions.None, BuildTarget.WebGL)) 
		{
			Debug.Log ("SUESSFUL!!!");
		}
	} 

}
