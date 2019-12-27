using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Spawnertype
{
	Spawn_Left_1,Spawn_Left_2,Spawn_Right_1,Spawn_Right_2
}
  

public class Spawner : MonoBehaviour
{

    public Spawnertype spawnertype;
    public GameObject[] objects;
    public float delaytime=2f;
    public float spawnrate=1f;

    // Use this for initialization
    void Start ()
    {
            
		
    }
	
    //Update is called once per frame
    void Update ()
    {
	    if(Time.time>delaytime)
        {
            if(spawnertype == Spawnertype.Spawn_Left_1 && GameManager.Spawn_Left_1timer <=0f)
            {
                Spawners();
                GameManager.Spawn_Right_1timer = 2f;
            }
            if(spawnertype == Spawnertype.Spawn_Right_1 && GameManager.Spawn_Right_1timer <=0f)
            {
                Spawners();
                GameManager.Spawn_Left_1timer = 2f;
            }
            if(spawnertype ==  Spawnertype.Spawn_Left_2 && GameManager.Spawn_Left_2timer <=0f)
            {
                Spawners();
                GameManager.Spawn_Right_2timer = 2f;
            }
            if(spawnertype == Spawnertype.Spawn_Right_2 && GameManager.Spawn_Right_2timer <=0f)
            {
                Spawners();
                GameManager.Spawn_Left_2timer = 2f;
            }
	    }
    }


    private void Spawners()
    {
        float randomness=spawnrate*Time.deltaTime;
        if (randomness<Random.value)
        {
            int spawnnumber=Random.Range(0, 2);
            GameObject go =Instantiate(objects[spawnnumber]) as GameObject;
            go.transform.position=this.transform.position;
        }
        NextLoadTime();
    }


    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(this.transform.position,0.4f);
    }


    void NextLoadTime()
    {
        delaytime=Time.time+delaytime;
    }
}