using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class MoveToGoalAgent : Agent
{

  [SerializeField] private Transform targetTransform;

  public override void CollectObservations(VectorSensor sensor)
  {
    sensor.AddObservation(transform.position);
    sensor.AddObservation(targetTransform.position);
  }
  public override void OnActionReceived(ActionBuffers actions)
  {
    float moveX = actions.ContinuousActions[0];
    float moveZ = actions.ContinuousActions[1];

    float moveSpeed = 1f;
    transform.position += new Vector3(moveX, 0, moveZ) * Time.deltaTime * moveSpeed;
  }

  private void OnTriggerEnter(Collider other) {
    // Use AddReward if the rewards should be accumulative. E.g. with a car driving-AI.
    SetReward(1f);
  }
}
