using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private const float yValue = 0f;
    [SerializeField] public float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        //Inputs are messed up a little bit because of the player model being a capsule
        float zValue = GetZValue();
        float xValue = GetXValue();
        transform.Translate(xValue, yValue, zValue);
    }

    float GetZValue()
    {
        return GetAxisMovingValue("Horizontal");
    }

    float GetXValue()
    {
        return -GetAxisMovingValue("Vertical");
    }

    float GetAxisMovingValue(string axisName)
    {
        return Input.GetAxis(axisName) * Time.deltaTime * moveSpeed;
    }
}
