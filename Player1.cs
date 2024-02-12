using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Player1 : MonoBehaviour
{
    private Player thePlayer;
    public TextMeshPro tm;
    public GameObject destinationGo;
    private float speed = 1.0f;
    void Start()
    {

        this.thePlayer = new Player("Mike");
        tm.text = this.thePlayer.getName() + " -> " + this.thePlayer.getHP();
        //this.gameObject.transform.position = this.destinationGo.transform.position;

    }


    private void Update()
        
    {
        if(Vector3.Distance(this.gameObject.transform.position, this.destinationGo.transform.position) > 1.0f)
        {
            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, this.destinationGo.transform.position, this.speed);
        }
       
    }
}
