using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetingBackground : MonoBehaviour
{

    private BoxCollider2D boxCollider2D;
    

    private float sizeX;

    private void Awake() {
        boxCollider2D = GetComponent<BoxCollider2D>();
        sizeX = boxCollider2D.size.x;
    }

    private void Update() {
        
        if(transform.position.x < -sizeX){
            Reposition();
        }
        //Verifica se é menor do que o -sizeX
        //Reposiciona sizeX
    }

    private void Reposition() {
        transform.position = new Vector3(sizeX,transform.position.y,transform.position.z);
    }

}
