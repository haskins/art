using UnityEngine;
using System.Collections;

public class HintHelper : MonoBehaviour {

	private static int currentHint = 0;
	public static bool gmAllFound = false;

	// Use this for initialization
	void Start () {
	
	}

	public void getNextHint(){

		print ("getting hint");

		if (gmAllFound == true) {
			HuntHintHelpUpdate.setText("Congratulations, you have found all the Grandmaster targets. Now leave.");
		} else {

			do {
				currentHint++;
				currentHint = currentHint % SaveLoad.targets [2].Length;
			} while(SaveLoad.targets [2][currentHint] && currentHint < SaveLoad.targets[2].Length);

			//currentHint query database for that
			CustomParse.getHint (2, currentHint);
			print ("saving hint text");
			print ("num: " + currentHint);
		}
	}

	public void getPrevHint(){
		
		print ("getting hint");

		if (gmAllFound == true) {
			HuntHintHelpUpdate.setText("Congratulations, you have found all the Grandmaster targets. Now leave.");
		} else {
		
			do {
				currentHint--;
				if (currentHint == -1)
					currentHint = SaveLoad.targets [2].Length - 1;
			} while(currentHint >= 0 && SaveLoad.targets [2][currentHint]);
		
			//currentHint query database for that
			CustomParse.getHint (2, currentHint);
			print ("saving hint text");
			print ("num: " + currentHint);
		}
	}
}
