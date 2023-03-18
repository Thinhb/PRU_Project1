using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AfollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update 
    public AstarPath script;
    public float interpVelocity;
    public float minDistance;
    public float followDistance;
    public GameObject target;
    public Vector3 offset;
    Vector3 targetPos;
    void Start()
    {
        targetPos = script.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target)
        {
            Vector3 posNoZ = script.transform.position;
            posNoZ.z = target.transform.position.z;

            Vector3 targetDirection = (target.transform.position - posNoZ);

            interpVelocity = targetDirection.magnitude * 20f;

            targetPos = script.transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);

            script.transform.position = Vector3.Lerp(script.transform.position, targetPos + offset, 0.25f);

        }

    }
}
