using UnityEngine;
using System.Collections;

public class skyboxcontrol : MonoBehaviour {
	public Material[] mats;

	//public Material skybox01;
	//public Material skybox02;
	//public Material skybox03;
	//public Material skybox04;

	int index;
	// Use this for initialization
	void Start () {

		InvokeRepeating ("ChangeSkyBox", 0, 1f);

	}
	void ChangeSkyBox()
	{
		RenderSettings.skybox = mats [index];
		index++;
		index %= mats.Length;
	}
}
