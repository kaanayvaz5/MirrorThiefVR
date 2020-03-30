using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorHands : MonoBehaviour
{
    public GameObject rightHand;
    public GameObject leftHand;
    public bool mirrorRight;
    public bool mirrorLeft;
    public Transform playerTransform;

    void LateUpdate()
    {
        Transform right = rightHand.GetComponent<Transform>();
        Transform left = leftHand.GetComponent<Transform>();

        if (mirrorRight)
        {
            Mirror(right, left);
        }
        else if (mirrorLeft)
        {
            Mirror(left, right);
        }

    }
    Vector3 ReflectRelativeVector(Vector3 relativeVec)
    {
        return relativeVec + Vector3.Dot(relativeVec, playerTransform.right) * playerTransform.right * -2f;
    }
    void Mirror(Transform sourceTransform, Transform oppositeTransform)
    {
        // Determine opposite hand position
        Vector3 playerToSourceHand = sourceTransform.position - playerTransform.position;
        Vector3 playerToOppHand = ReflectRelativeVector(playerToSourceHand);
        oppositeTransform.position = playerTransform.position + playerToOppHand;

        // Determine opposite hand rotation
        Vector3 forwardVec = ReflectRelativeVector(sourceTransform.forward);
        Vector3 upVec = ReflectRelativeVector(sourceTransform.up);
        oppositeTransform.rotation = Quaternion.LookRotation(forwardVec, upVec);
    }


}