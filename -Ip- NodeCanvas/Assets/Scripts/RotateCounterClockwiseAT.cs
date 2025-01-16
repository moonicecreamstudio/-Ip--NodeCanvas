using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.Mathematics;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions
{

    public class RotateCounterClockwiseAT : ActionTask
    {

        Rigidbody rb;
        Vector3 eulerAngleVelocity;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit()
        {
            rb = agent.GetComponent<Rigidbody>();
            eulerAngleVelocity = new Vector3(0, -20, 0);
            return null;
        }

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute()
        {
            //EndAction(true);
        }

        //Called once per frame while the action is active.
        protected override void OnUpdate()
        {
            Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }

        //Called when the task is disabled.
        protected override void OnStop()
        {

        }

        //Called when the task is paused.
        protected override void OnPause()
        {

        }
    }
}