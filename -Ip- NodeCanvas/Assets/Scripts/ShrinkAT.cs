using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ShrinkAT : ActionTask {

		GameObject playerGear;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			playerGear = GameObject.Find("Player Gear");
			//EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			if (playerGear.transform.localScale.x >= 0.5f || playerGear.transform.localScale.y >= 0.5f || playerGear.transform.localScale.z >= 0.5f)
			{
                playerGear.transform.localScale += new Vector3(-0.1f, 0, -0.1f) * Time.deltaTime;
            }

		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}