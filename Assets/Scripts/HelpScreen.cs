using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HelpScreen : MonoBehaviour
{
    public KeyCode setScreen = KeyCode.Space;
    public GameObject helpScreen;
    
    void Start() {
    	helpScreen.SetActive(!helpScreen.activeSelf);
    }
    
    void Update() {
    	if(Input.GetKeyDown(setScreen)) {
    		helpScreen.SetActive(!helpScreen.activeSelf);
    	}
    }
}
