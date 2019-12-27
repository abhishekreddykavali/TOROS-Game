using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullController : MonoBehaviour
{
    private float middlepoint;
    public bool IsthebullonLeft;

    // Use this for initialization
    void Start()
    {
        middlepoint = Screen.width / 2;

    }

    // Update is called once per frame
    void Update()
    {
        checkmousepress();

    }
    private void checkmousepress()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Input.mousePosition.x < middlepoint && this.gameObject.tag == "Left_Bull")
            {
                movebull();
            }
            if (Input.mousePosition.x > middlepoint && this.gameObject.tag == "Right_Bull")
            {
                movebull();
            }
        }
    }
    private void movebull()
    {
        if (IsthebullonLeft)
        {
            IsthebullonLeft = false;
            this.transform.Translate(Vector3.right * 1.5f);
        }
        else if (IsthebullonLeft == false)
        {
            this.transform.Translate(Vector3.left * 1.5f);

            IsthebullonLeft = true;
        }

    }

}
