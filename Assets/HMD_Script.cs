using UnityEngine;
using System.Collections;

public class HMD_Script : MonoBehaviour {
	public Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter() {
		rend.material.color = Color.yellow;
		Debug.Log("salam");
	}
	void OnMouseOver() {
		rend.material.color = Color.yellow;
		Debug.Log ("byebye");
	}
	void OnMouseExit() {
		
	}
}
