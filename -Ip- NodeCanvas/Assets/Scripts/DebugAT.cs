using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;	//By default, this is not here


namespace NodeCanvas.Tasks.Actions {

	public class DebugAT : ActionTask {

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			//Happens only once
			//Spawning an instance of something
			//Intializing values that are consistent
			//Randomizing values
			//Getting a component
			//Interface
			Debug.Log("Debug is intialized.");

			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
            //Like onEnable
            //Setting default behaviour
            //Doing a singular thing
            //Resetting values

            //Important to comment this out, might get unexpected behaviour
            //EndAction(true); //The moment this is called, we stop any running behaviour.

            Debug.Log("Debug is executing.");
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
            Debug.Log("Debug is updating.");
			//agent.transform.position += agent.transform.forward * 3f * Time.deltaTime;
			//Rigidbody rb = agent.GetComponent<Rigidbody>();
			//agent.gameObject.SetActive(true);
        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}