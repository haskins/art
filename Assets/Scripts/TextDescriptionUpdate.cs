﻿/*==============================================================================
Updates the text on screen for scavenger hunt description.
==============================================================================*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextDescriptionUpdate : MonoBehaviour
{
	
	public static Text textObject;
	public static string textToDisplay;
	
	public static void setText (string s)
	{
		textToDisplay = s;
	}
	
	
	// Use this for initialization
	public void Start ()
	{
		textObject = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	public  void Update ()
	{
		textObject.text = textToDisplay;
	}
}
