using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//created by Dharmesh Rana for Dream in Reality 

public class GridSpace : MonoBehaviour {

    public Button button;
    public Text buttonText;
    public string playerSide;

    private GameControl gameControl;
    
    void Start () 
	{
		
	}
	
	
	void Update () 
	{
		
	}

    public void SetSpace()
    {
        buttonText.text = gameControl.GetPlayerSide();
        button.interactable = false;
        gameControl.EndTurn();
    }

    public void SetGameControllerReference(GameControl controller)
    {
        gameControl = controller;
    }
}
