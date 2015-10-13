using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad : MonoBehaviour 
{
	
	public static bool[][] targets = new bool[3][];

	/**
	 * Serializes the list "targets" and saves to a file. 
	 */
	public static void save() {
		print ("saving");
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath+"/scavangerData.save");
		bf.Serialize(file, targets);
		file.Close();
	}
	
	/**
	 * Loads the files from Application.persistantDataPath(if it exists), deserializes it.
	 */
	public void Start() {
		print("SAVE LOCATION "+Application.persistentDataPath);
		if (File.Exists (Application.persistentDataPath + "/scavangerData.save")) {
			print ("loading save file");
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/scavangerData.save", FileMode.Open);
			SaveLoad.targets = (bool[][])bf.Deserialize (file);
			file.Close ();
		} else {
			init ();
		}

		truthChecker ();
	}
	
	/**
	 * Initializes the targets list if one was not loaded, or a restet is required. 
	 * 10 - Easy
	 * 10 - Normal
	 * 20 - Grandmaster
	 */
	public void init() {
		print ("creating new save file");
		targets[0] = new bool[10];
		targets[1] = new bool[10];
		targets[2] = new bool[20];
		
		save ();

		truthChecker ();

		HuntHintHelpUpdate.clear ();
	}



	public static bool getVal(int x, int y){
		return targets [x] [y];
	}	


	public static void truthChecker(){
		bool result = true;
		for (int i = 0; i< targets[2].Length; i++) {
			if (targets [2] [i] == false) {
				result = false;
				break;
			}
		}
		HintHelper.gmAllFound = result;
		print ("everything is " + result);
	}

	public static void setVal(int x, int y){
		print ("setting value");
		targets [x] [y] = true;
		save ();
		truthChecker ();
	}	
}