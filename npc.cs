using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    //Npc Vida
    public int health = 10;
    //Npc Nivel
    public int level = 1;
    //Npc Velocidad
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        health = health + level;
        Debug.Log("Lives: " +  health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = this.transform.position;

        newPosition.z = newPosition.z + speed * Time.deltaTime;

        this.transform.position = newPosition;
    }
}
