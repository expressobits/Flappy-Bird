using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    
    public float secondsToGenerate;

    public GameObject prefab;
    public GameObject spawn;

    [SerializeField]
    private float minY;

    [SerializeField]
    private float maxY;


    private void Start() {
        StartCoroutine(GenerateCoroutine());
    }

    private void Update() {
        
        
    }

    private void OnDisable() {
        StopCoroutine(GenerateCoroutine());
    }

    private IEnumerator GenerateCoroutine(){
        //Gerar
        while(!GameManager.instance.gameOver){
            Generate();
            yield return new WaitForSeconds(secondsToGenerate);
        }
    }

    private void Generate(){

        float randomY = Random.Range(minY,maxY);

        Vector3 position = new Vector3(
            spawn.transform.position.x,
            randomY,
            spawn.transform.position.z);

        Instantiate(prefab,position,spawn.transform.rotation);

    }
}
