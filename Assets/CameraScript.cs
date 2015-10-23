using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Timers;

public class CameraScript : MonoBehaviour {

	public GameObject myTarget;
	private float speedMod = 3.0f;//a speed modifier
	private Vector3 point;
	float timeLeft = 4.5f;

	private List<GameObject> BlinkingLEDs;
	private List<GameObject> AllLEDs;
	Color BlinkingColor;
	public GameObject LEDRight1;
	public GameObject LEDRight2;
	public GameObject LEDRight3;
	public GameObject LEDRight4;
	public GameObject LEDRight5;
	public GameObject LEDRight6;
	public GameObject LEDRight7;
	public GameObject LEDLeft1;
	public GameObject LEDLeft2;
	public GameObject LEDLeft3;
	public GameObject LEDLeft4;
	public GameObject LEDLeft5;
	public GameObject LEDLeft6;
	public GameObject LEDLeft7;

	// Use this for initialization
	void Start () {
		point = myTarget.transform.position;//get target's coords
		transform.LookAt(point);//makes the camera look to it

		BlinkingLEDs = null;
		LEDRight1 = GameObject.Find ("HMD/LEDRight1");
		LEDRight2 = GameObject.Find ("HMD/LEDRight2");
		LEDRight3 = GameObject.Find ("HMD/LEDRight3");
		LEDRight4 = GameObject.Find ("HMD/LEDRight4");
		LEDRight5 = GameObject.Find ("HMD/LEDRight5");
		LEDRight6 = GameObject.Find ("HMD/LEDRight6");
		LEDRight7 = GameObject.Find ("HMD/LEDRight7");
		LEDLeft1 = GameObject.Find ("HMD/LEDLeft1");
		LEDLeft2 = GameObject.Find ("HMD/LEDLeft2");
		LEDLeft3 = GameObject.Find ("HMD/LEDLeft3");
		LEDLeft4 = GameObject.Find ("HMD/LEDLeft4");
		LEDLeft5 = GameObject.Find ("HMD/LEDLeft5");
		LEDLeft6 = GameObject.Find ("HMD/LEDLeft6");
		LEDLeft7 = GameObject.Find ("HMD/LEDLeft7");
		AllLEDs = new List<GameObject> {LEDRight1,LEDRight2,LEDRight3,LEDRight4,LEDRight5,LEDRight6,LEDRight7,LEDLeft1,LEDLeft2,LEDLeft3,LEDLeft4,LEDLeft5,LEDLeft6,LEDLeft7};
	}
	
	// Update is called once per frame
	void Update () {

		//rotate the camera with specific speed Mod
		//transform.RotateAround (point,new Vector3(0.0f,1.0f,0.0f),20 * Time.deltaTime * speedMod);
		if (Input.GetMouseButton (0))
		{
			if(Input.GetAxis("Mouse X")<0){
				//Code for action on mouse moving left
				transform.RotateAround (point, new Vector3 (0.0f, 1.0f, 0.0f), 20 * Time.deltaTime * speedMod);
			}
			if(Input.GetAxis("Mouse X")>0){
				//Code for action on mouse moving right
				transform.RotateAround (point, new Vector3 (0.0f, -1.0f, 0.0f), 20 * Time.deltaTime * speedMod);
			}
			if(Input.GetAxis("Mouse Y")<0){
				//Code for action on mouse moving up
				transform.RotateAround (point, new Vector3 (-1.0f, 0.0f, 0.0f), 20 * Time.deltaTime * speedMod);
			}
			if(Input.GetAxis("Mouse Y")>0){
				//Code for action on mouse moving down
				transform.RotateAround (point, new Vector3 (1.0f, 0.0f, 0.0f), 20 * Time.deltaTime * speedMod);
			}
		}

		if (BlinkingLEDs != null) {
			timeLeft -= Time.deltaTime;
			if(timeLeft < 4.5f && timeLeft> 4f)
			{
				foreach(GameObject blinkingLED in BlinkingLEDs)
				{
					blinkingLED.gameObject.renderer.material.color = BlinkingColor;
				}
			}
			else if(timeLeft < 4f && timeLeft> 3.5f)
			{
				foreach(GameObject blinkingLED in BlinkingLEDs)
				{
					blinkingLED.gameObject.renderer.material.color = Color.black;
				}
			}
			else if(timeLeft < 3.5f && timeLeft> 3f)
			{
				foreach(GameObject blinkingLED in BlinkingLEDs)
				{
					blinkingLED.gameObject.renderer.material.color = BlinkingColor;
				}
			}
			else if(timeLeft < 3f && timeLeft> 2.5f)
			{
				foreach(GameObject blinkingLED in BlinkingLEDs)
				{
					blinkingLED.gameObject.renderer.material.color = Color.black;
				}
			}
			else if(timeLeft < 2.5f && timeLeft> 2f)
			{
				foreach(GameObject blinkingLED in BlinkingLEDs)
				{
					blinkingLED.gameObject.renderer.material.color = BlinkingColor;
				}
			}
			else if(timeLeft < 2f && timeLeft> 1.5f)
			{
				foreach(GameObject blinkingLED in BlinkingLEDs)
				{
					blinkingLED.gameObject.renderer.material.color = Color.black;
				}
			}
			else if(timeLeft < 1.5f && timeLeft> 1f)
			{
				foreach(GameObject blinkingLED in BlinkingLEDs)
				{
					blinkingLED.gameObject.renderer.material.color = BlinkingColor;
				}
			}
			else if(timeLeft < 1f && timeLeft> 0.5f)
			{
				foreach(GameObject blinkingLED in BlinkingLEDs)
				{
					blinkingLED.gameObject.renderer.material.color = Color.black;
				}
			}
			else if(timeLeft < 0.5f && timeLeft> 0f)
			{
				foreach(GameObject blinkingLED in BlinkingLEDs)
				{
					blinkingLED.gameObject.renderer.material.color = BlinkingColor;
				}
			}
			else
			{
				foreach(GameObject blinkingLED in BlinkingLEDs)
				{
					blinkingLED.gameObject.renderer.material.color = Color.black;
				}
				BlinkingLEDs=null;
			}
		}
	}

	public void buttonReset(){
		this.transform.position = new Vector3 (4.3f,0,4.3f);
		this.transform.localEulerAngles = new Vector3 (0, 220f, 0);
	}
	public void buttonDownEvent(){
		transform.RotateAround (point, new Vector3 (1.0f, 0.0f, 0.0f), 20 * Time.deltaTime * speedMod);
	}
	public void buttonUpEvent(){
		transform.RotateAround (point, new Vector3 (-1.0f, 0.0f, 0.0f), 20 * Time.deltaTime * speedMod);
	}
	public void buttonRightEvent(){
		transform.RotateAround (point, new Vector3 (0.0f, 1.0f, 0.0f), 20 * Time.deltaTime * speedMod);
	}
	public void buttonLeftEvent(){
		transform.RotateAround (point, new Vector3 (0.0f, -1.0f, 0.0f), 20 * Time.deltaTime * speedMod);
	}


	public void buttonLightLeft(){
		List<GameObject> gameObjects = new List<GameObject> {LEDLeft4};
		blinking(gameObjects, Color.green);
	}
	public void buttonLightRight(){
		List<GameObject> gameObjects = new List<GameObject> {LEDRight4};
		blinking(gameObjects, Color.green);
	}
	public void buttonLightDown(){
		List<GameObject> gameObjects = new List<GameObject> {LEDRight6,LEDLeft6};
		blinking(gameObjects, Color.green);
	}
	public void buttonLightUp(){
		List<GameObject> gameObjects = new List<GameObject> {LEDRight2,LEDLeft2};
		blinking(gameObjects, Color.green);
	}
	public void buttonLightDownPrime(){
		List<GameObject> gameObjects = new List<GameObject> {LEDRight5,LEDRight6,LEDRight7,LEDLeft5,LEDLeft6,LEDLeft7};
		blinking(gameObjects, Color.green);
	}
	public void buttonLightUpPrime(){
		List<GameObject> gameObjects = new List<GameObject> {LEDRight1,LEDRight2,LEDRight3,LEDLeft1,LEDLeft2,LEDLeft3};
		blinking(gameObjects, Color.green);
	}
	public void buttonLightDownLeft(){
		List<GameObject> gameObjects = new List<GameObject> {LEDLeft5,LEDLeft6};
		blinking(gameObjects, Color.green);
	}
	public void buttonLightDownRight(){
		List<GameObject> gameObjects = new List<GameObject> {LEDRight5,LEDRight6};
		blinking(gameObjects, Color.green);
	}
	public void buttonLightUpLeft(){
		List<GameObject> gameObjects = new List<GameObject> {LEDLeft2,LEDLeft3};
		blinking(gameObjects, Color.green);
	}
	public void buttonLightUpRight(){
		List<GameObject> gameObjects = new List<GameObject> {LEDRight2,LEDRight3};
		blinking(gameObjects, Color.green);
	}
	public void buttonLightConfirm(){
		List<GameObject> gameObjects = AllLEDs;
		blinking(gameObjects, Color.green);
	}
	public void buttonLightReject(){
		List<GameObject> gameObjects = new List<GameObject> {LEDRight1,LEDRight3,LEDRight5,LEDRight7,LEDLeft1,LEDLeft3,LEDLeft5,LEDLeft7};
		blinking(gameObjects, Color.red);
	}

	private void blinking(List<GameObject> gameObjects, Color blinkingColor){
		BlinkingLEDs = null;
		timeLeft = 4.5f;
		BlinkingLEDs = gameObjects;
		BlinkingColor = blinkingColor;
		foreach (GameObject blinkingLED in AllLEDs) {
			blinkingLED.gameObject.renderer.material.color = Color.black;
		}

	}
}
