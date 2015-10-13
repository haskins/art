/*==============================================================================
This provides functionality for Vuforia's AR tools when an action occurs.

Original file:
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Qualcomm Connected Experiences, Inc.

Modifications:
Devon Harker
Josh Haskins
Vincent Tennant
==============================================================================*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Parse;

namespace Vuforia
{
	/// <summary>
	/// A custom handler that implements the ITrackableEventHandler interface.
	/// </summary>
	public class DefaultTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
	{
		public static bool dismissButtonStatus = false;


        #region PRIVATE_MEMBER_VARIABLES
 
		private TrackableBehaviour mTrackableBehaviour;
    
        #endregion // PRIVATE_MEMBER_VARIABLES



        #region UNTIY_MONOBEHAVIOUR_METHODS
    
		void Start ()
		{
			mTrackableBehaviour = GetComponent<TrackableBehaviour> ();
			if (mTrackableBehaviour) {
				mTrackableBehaviour.RegisterTrackableEventHandler (this);
			}
		}

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

		/// <summary>
		/// Implementation of the ITrackableEventHandler function called when the
		/// tracking state changes.
		/// </summary>
		public void OnTrackableStateChanged (
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
		{
			if (newStatus == TrackableBehaviour.Status.DETECTED ||
				newStatus == TrackableBehaviour.Status.TRACKED ||
				newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {
				OnTrackingFound ();
			} else {
				OnTrackingLost ();
			}
		}

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS

		// Determine which target has been found and display appropriate augmented data.
		private void OnTrackingFound ()
		{
			Renderer[] rendererComponents = GetComponentsInChildren<Renderer> (true);
			Collider[] colliderComponents = GetComponentsInChildren<Collider> (true);

			// Clear status as object has been found.
			TextStatusUpdate.setText ("");

			// Enable rendering of specific object that belongs to our target.
			foreach (Renderer component in rendererComponents) {


				//easy targets
				if (component.name == "e1") {
					component.enabled = true;
					SaveLoad.setVal(0,0);
					CustomParse.updateHuntText (0, 0);
				} else if (component.name == "e2") {
					component.enabled = true;
					SaveLoad.setVal(0,1);
					CustomParse.updateHuntText (0, 1);
				} else if (component.name == "e3") {
					component.enabled = true;
					SaveLoad.setVal(0,2);
					CustomParse.updateHuntText (0, 2);
				} else if (component.name == "e4") {
					component.enabled = true;
					SaveLoad.setVal(0,3);
					CustomParse.updateHuntText (0, 3);
				} else if (component.name == "e5") {
					component.enabled = true;
					SaveLoad.setVal(0,4);
					CustomParse.updateHuntText (0, 4);
				} else if (component.name == "e6") {
					component.enabled = true;
					SaveLoad.setVal(0,5);
					CustomParse.updateHuntText (0, 5);
				} else if (component.name == "e7") {
					component.enabled = true;
					SaveLoad.setVal(0,6);
					CustomParse.updateHuntText (0, 6);
				} else if (component.name == "e8") {
					component.enabled = true;
					SaveLoad.setVal(0,7);
					CustomParse.updateHuntText (0, 7);
				} else if (component.name == "e9") {
					component.enabled = true;
					SaveLoad.setVal(0,8);
					CustomParse.updateHuntText (0, 8);
				} else if (component.name == "e10") {
					component.enabled = true;
					SaveLoad.setVal(0,9);
					CustomParse.updateHuntText (0, 9);
				} 


				//normal targets
				if (component.name == "n1") {
					component.enabled = true;
					SaveLoad.setVal(1,0);
					CustomParse.updateHuntText (1, 0);
				} else if (component.name == "n2") {
					component.enabled = true;
					SaveLoad.setVal(1,1);
					CustomParse.updateHuntText (1, 1);
				} else if (component.name == "n3") {
					component.enabled = true;
					SaveLoad.setVal(1,2);
					CustomParse.updateHuntText (1, 2);
				} else if (component.name == "n4") {
					component.enabled = true;
					SaveLoad.setVal(1,3);
					CustomParse.updateHuntText (1, 3);
				} else if (component.name == "n5") {
					component.enabled = true;
					SaveLoad.setVal(1,4);
					CustomParse.updateHuntText (1, 4);
				} else if (component.name == "n6") {
					component.enabled = true;
					SaveLoad.setVal(1,5);
					CustomParse.updateHuntText (1, 5);
				} else if (component.name == "n7") {
					component.enabled = true;
					SaveLoad.setVal(1,6);
					CustomParse.updateHuntText (1, 6);
				} else if (component.name == "n8") {
					component.enabled = true;
					SaveLoad.setVal(1,7);
					CustomParse.updateHuntText (1, 7);
				} else if (component.name == "n9") {
					component.enabled = true;
					SaveLoad.setVal(1,8);
					CustomParse.updateHuntText (1, 8);
				} else if (component.name == "n10") {
					component.enabled = true;
					SaveLoad.setVal(1,9);
					CustomParse.updateHuntText (1, 9);
				}  else if (component.name == "n11") {
					component.enabled = true;
					SaveLoad.setVal(1,10);
					CustomParse.updateHuntText (1, 10);
				}  else if (component.name == "n12") {
					component.enabled = true;
					SaveLoad.setVal(1,11);
					CustomParse.updateHuntText (1, 11);
				}  else if (component.name == "n13") {
					component.enabled = true;
					SaveLoad.setVal(1,12);
					CustomParse.updateHuntText (1, 12);
				}  else if (component.name == "n14") {
					component.enabled = true;
					SaveLoad.setVal(1,13);
					CustomParse.updateHuntText (1, 13);
				} 

				//grandmaster targets
				if (component.name == "gm01") {
					component.enabled = true;
					SaveLoad.setVal(2,0);
					CustomParse.updateHuntText (2, 0);
				} else if (component.name == "gm02") {
					component.enabled = true;
					SaveLoad.setVal(2,1);
					CustomParse.updateHuntText (2, 1);
				} else if (component.name == "gm03") {
					component.enabled = true;
					SaveLoad.setVal(2,2);
					CustomParse.updateHuntText (2, 2);
				} else if (component.name == "gm04") {
					component.enabled = true;
					SaveLoad.setVal(2,3);
					CustomParse.updateHuntText (2, 3);
				} else if (component.name == "gm05") {
					component.enabled = true;
					SaveLoad.setVal(2,4);
					CustomParse.updateHuntText (2, 4);
				} else if (component.name == "gm06") {
					component.enabled = true;
					SaveLoad.setVal(2,5);
					CustomParse.updateHuntText (2, 5);
				} else if (component.name == "gm07") {
					component.enabled = true;
					SaveLoad.setVal(2,6);
					CustomParse.updateHuntText (2, 6);
				} else if (component.name == "gm08") {
					component.enabled = true;
					SaveLoad.setVal(2,7);
					CustomParse.updateHuntText (2, 7);
				} else if (component.name == "gm09") {
					component.enabled = true;
					SaveLoad.setVal(2,8);
					CustomParse.updateHuntText (2, 8);
				} else if (component.name == "gm10") {
					component.enabled = true;
					SaveLoad.setVal(2,9);
					CustomParse.updateHuntText (2, 9);
				}  else if (component.name == "gm11") {
					component.enabled = true;
					SaveLoad.setVal(2,10);
					CustomParse.updateHuntText (2, 10);
				}  else if (component.name == "gm12") {
					component.enabled = true;
					SaveLoad.setVal(2,11);
					CustomParse.updateHuntText (2, 11);
				}  else if (component.name == "gm13") {
					component.enabled = true;
					SaveLoad.setVal(2,12);
					CustomParse.updateHuntText (2, 12);
				}  else if (component.name == "gm14") {
					component.enabled = true;
					SaveLoad.setVal(2,13);
					CustomParse.updateHuntText (2, 13);
				} else if (component.name == "gm15") {
					component.enabled = true;
					SaveLoad.setVal(2,14);
					CustomParse.updateHuntText (2, 14);
				} else if (component.name == "gm16") {
					component.enabled = true;
					SaveLoad.setVal(2,15);
					CustomParse.updateHuntText (2, 15);
				} else if (component.name == "gm17") {
					component.enabled = true;
					SaveLoad.setVal(2,16);
					CustomParse.updateHuntText (2, 16);
				} else if (component.name == "gm18") {
					component.enabled = true;
					SaveLoad.setVal(2,17);
					CustomParse.updateHuntText (2, 17);
				} else if (component.name == "gm19") {
					component.enabled = true;
					SaveLoad.setVal(2,18);
					CustomParse.updateHuntText (2, 18);
				} else if (component.name == "gm20") {
					component.enabled = true;
					SaveLoad.setVal(2,19);
					CustomParse.updateHuntText (2, 19);
				} else if (component.name == "gm21") {
					component.enabled = true;
					SaveLoad.setVal(2,20);
					CustomParse.updateHuntText (2, 20);
				} else if (component.name == "gm22") {
					component.enabled = true;
					SaveLoad.setVal(2,21);
					CustomParse.updateHuntText (2, 21);
				} else if (component.name == "gm23") {
					component.enabled = true;
					SaveLoad.setVal(2,22);
					CustomParse.updateHuntText (2, 22);
				} else if (component.name == "gm24") {
					component.enabled = true;
					SaveLoad.setVal(2,23);
					CustomParse.updateHuntText (2, 23);
				} 



			}

			// Enable colliders:
			foreach (Collider component in colliderComponents) {
				component.enabled = true;
			}

			Debug.Log ("Trackable " + mTrackableBehaviour.TrackableName + " found");
		}

		// Disables any enabled AR objects.
		private void OnTrackingLost ()
		{
			Renderer[] rendererComponents = GetComponentsInChildren<Renderer> (true);
			Collider[] colliderComponents = GetComponentsInChildren<Collider> (true);

			// Disable rendering:
			foreach (Renderer component in rendererComponents) {
				component.enabled = false;				
			}

			// Clears the various text objects for room information.
			TextRoomNumberUpdate.setText ("");
			TextProfNameUpdate.setText ("");
			TextRoomTypeUpdate.setText ("");
			TextHoursDayUpdate.setText ("");
			TextHoursEndUpdate.setText ("");
			TextHoursStartUpdate.setText ("");
			TextHoursTitleUpdate.setText ("");
			TextCourseTitleUpdate.setText ("");

			// Clears the various text objects for scavenger hunt.
			TextTitleUpdate.setText ("");
			TextDescriptionUpdate.setText ("");
			TextClueUpdate.setText ("");
			TextProgressUpdate.setText ("");

			// Sets status to waiting for target.
			TextStatusUpdate.setText ("Waiting for target");
			
			// Disable colliders:
			foreach (Collider component in colliderComponents) {
				component.enabled = false;
			}

			Debug.Log ("Trackable " + mTrackableBehaviour.TrackableName + " lost");
		}

        #endregion // PRIVATE_METHODS
	}
}
