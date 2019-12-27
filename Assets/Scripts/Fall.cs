using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
    }
	
	
    private void OnTriggerEnter2D(Collider2D col)
    {
        if ((this.gameObject.tag == "Grass_1" || this.gameObject.tag == "Grass_2") && (col.gameObject.tag == "Left_Bull" || col.gameObject.tag == "Right_Bull"))
        {
            Destroy(this.gameObject);
            Score.AddScore(1);
        }
        if ((this.gameObject.tag == "Goat_1" || this.gameObject.tag == "Goat_2") && (col.gameObject.tag == "Left_Bull" || col.gameObject.tag == "Right_Bull"))
        {
            Death();
        }
    }


    private void Death()
    {

    }
}
