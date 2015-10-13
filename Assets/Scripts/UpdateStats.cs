using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateStats : MonoBehaviour {

	public GameObject imageOnPanel;
	private RawImage img;
	public int difficulty;
	public int location;


	// Use this for initialization
	void Start () {
		img = (RawImage)imageOnPanel.GetComponent<RawImage> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (SaveLoad.getVal (difficulty, location)) {
			img.color = Color.green;
		} else {
			img.color = Color.red;
		}
	}

}
