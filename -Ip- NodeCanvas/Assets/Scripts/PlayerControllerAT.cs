using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class PlayerControllerAT : ActionTask {

        GameObject playerGear;
        Rigidbody rb;
        float moveSpeed;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
            rb = agent.GetComponent<Rigidbody>();
            moveSpeed = 1.5f;
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
            if (Input.GetKey("w"))
            {
                rb.transform.position += new Vector3(0, 0, moveSpeed) * Time.deltaTime;
            }
            if (Input.GetKey("a"))
            {
                rb.transform.position -= new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
            }
            if (Input.GetKey("s"))
            {
                rb.transform.position -= new Vector3(0, 0, moveSpeed) * Time.deltaTime;
            }
            if (Input.GetKey("d"))
            {
                rb.transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
            }
            if (playerGear.transform.localScale.x <= 1)
            {
                playerGear.transform.localScale += new Vector3(0.2f, 0, 0.2f) * Time.deltaTime;
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