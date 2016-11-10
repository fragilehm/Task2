using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;


using System.Collections;

public class Bricks : MonoBehaviour {
    public GameObject brickParticle;

    Color[] colors;
    Renderer thisRend;
    void Start()

    {
        thisRend = GetComponent<Renderer>();
    }
        void OnCollisionEnter (Collision other)
    {
        
        
        if(thisRend.material.color == Color.green)
        {
            Instantiate(brickParticle, transform.position, Quaternion.identity);
            GM.instance.DestroyBrick();
            Destroy(gameObject);
        }
        else
        {
            thisRend.material.color = Color.green;
        }
       
    }
}
/*
 * 
 * 
public class ChangeMaterial : MonoBehaviour {
    
    public Material[] materialArray;

    public int pointer = 0;

    void Update(){
        if(pointer >= materialArray.Length()){
               Debug.Log("Error!!! Watch for fucking pointer!!!");
               pointer = 0;
        }else{

             gameObject.renderer.material = materialArray[pointer];

       }

    }

}


 
 * */
