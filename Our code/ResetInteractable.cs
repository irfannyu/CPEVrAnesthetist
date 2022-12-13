using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetInteractable : MonoBehaviour
{
    public void ResetTransform()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.identity;
        transform.localPosition = new Vector3(0, 0, 0);
        transform.localRotation = Quaternion.identity;
    }
}
