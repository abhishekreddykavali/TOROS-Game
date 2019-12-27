using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullcontroller : MonoBehaviour
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
            if (Input.mousePosition.x < middlepoint && this.gameObject.tag == "leftbull")
            {
                movebull();
            }
            if (Input.mousePosition.x > middlepoint && this.gameObject.tag == "rightbull")
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
            this.transform.Translate(Vector3.right * 1.8f);
        }
        else if (IsthebullonLeft == false)
        {
            this.transform.Translate(Vector3.left * 1.8f);

            IsthebullonLeft = true;
        }

    }

}
