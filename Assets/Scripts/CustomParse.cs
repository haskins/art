/*==============================================================================
Provides functionality for accessing the remote Parse Core database.
==============================================================================*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Threading.Tasks;
using Parse;
using System;

public class CustomParse : MonoBehaviour
{

	// Updates text for Scavenger Hunt.
	public static void  updateHuntText (int dif, int num)
	{
		ParseQuery<ParseObject> query = ParseObject.GetQuery ("ScavengerHunt").WhereEqualTo ("Entry_Number", num).WhereEqualTo ("Difficulty", dif);
		query.FirstAsync ().ContinueWith (t =>
		{
			ParseObject res = t.Result;
			TextDescriptionUpdate.setText (res.Get<string> ("Description"));
			TextTitleUpdate.setText (res.Get<string> ("Name"));

			if(dif != 2)
				TextClueUpdate.setText ("Hint: " + res.Get<string> ("Clue"));

		});

	}



	public static void getHint (int dif, int num)
	{
		ParseQuery<ParseObject> query = ParseObject.GetQuery ("ScavengerHunt").WhereEqualTo ("Entry_Number", num).WhereEqualTo ("Difficulty", dif);
		query.FirstAsync ().ContinueWith (t =>
	  {
			ParseObject res = t.Result;
			HuntHintHelpUpdate.setText(res.Get<string> ("Clue"));
		});


	}
}
