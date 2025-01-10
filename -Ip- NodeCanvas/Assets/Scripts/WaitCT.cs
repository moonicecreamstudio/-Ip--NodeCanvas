using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class WaitCT : ConditionTask {

		public float waitDuration;

		private float currentTimeWaiting = 0f;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			//Runs the very first time
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			//Run every time it's in the state
			currentTimeWaiting = 0F;
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			//Returns a value, boolean
			//When it's true, we can transition
			currentTimeWaiting += Time.deltaTime;

			return currentTimeWaiting > waitDuration;
		}
	}
}