using UnityEngine;
using System.Collections;

public class ReturnPlayer : MonoBehaviour
{

    public Transform ReturnPoint;


    public void OnControllerColliderHit(ControllerColliderHit hit)
    {

        hit.transform.position = ReturnPoint.position;

    }
}
