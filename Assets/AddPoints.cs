using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    public LixoSpawnerController lixoSpawnerController;
    public AudioSource source;
    private void OnCollisionEnter (Collision collision){
        if (collision.gameObject.CompareTag("Lixo")){
            Destroy(collision.gameObject);
            source.Play()
            lixoSpawnerController.AddToPoints(1);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
