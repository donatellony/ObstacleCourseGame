using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    float secondsToWaitBeforeFall;
    Rigidbody rigidBody;
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        Drop();
    }

    void Initialize()
    {
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody.useGravity = false;
        meshRenderer.enabled = false;
    }

    private void ShowObject()
    {
        rigidBody.useGravity = true;
        meshRenderer.enabled = true;
    }
    private void Drop()
    {
        if (Time.time >= secondsToWaitBeforeFall)
            ShowObject();
    }
}
