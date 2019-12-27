using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour {
 
public static float Spawn_Left_1timer = 2f;
public static float Spawn_Right_1timer = 2f;
public static float Spawn_Left_2timer = 2f;
public static float Spawn_Right_2timer = 2f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		decreasetimer();
	}
private void decreasetimer(){
Spawn_Left_1timer = Mathf.Clamp(Spawn_Left_1timer - Time.deltaTime,0f,2f);
Spawn_Right_1timer = Mathf.Clamp(Spawn_Right_1timer - Time.deltaTime,0f,2f);
Spawn_Left_2timer = Mathf.Clamp(Spawn_Left_2timer - Time.deltaTime,0f,2f);
Spawn_Right_2timer = Mathf.Clamp(Spawn_Right_2timer - Time.deltaTime,0f,2f);
}  
}

