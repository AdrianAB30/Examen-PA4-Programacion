using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int upKeyToMove;
    public int downKeyToMove;
    public float yDirectionToMove;
    public float ySpeedMovement;
    public float yMinLimitToMove;
    public float yMaxLimitToMove;
    private float yPosition;
    public string playerType;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            yDirectionToMove = 0;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            yDirectionToMove = 5;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            yDirectionToMove = -40;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            yDirectionToMove = -40;
        }
        yPosition =Mathf.Clamp(transform.position.y - ySpeedMovement + yDirectionToMove * Time.deltaTime,
            yMaxLimitToMove, yMinLimitToMove);
        transform.position = new Vector3(yPosition, transform.position.z);
    }
}

