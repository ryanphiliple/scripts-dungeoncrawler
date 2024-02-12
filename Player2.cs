using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Player2 : MonoBehaviour
{
    private Player thePlayer;
    public TextMeshPro tm2;
    


    void Start()
    {

       
        this.thePlayer = new Player("Dave");
        tm2.text = this.thePlayer.getName() + " -> " + this.thePlayer.getHP();
       
    }

    
    private void FixedUpdate()
    {
         this.thePlayer.display();
        /*if(Singleton.player1Turn == false)
        {
            print(Singleton.count);
            Singleton.count++;
            Singleton.count == true;
        }*/
    }
}
