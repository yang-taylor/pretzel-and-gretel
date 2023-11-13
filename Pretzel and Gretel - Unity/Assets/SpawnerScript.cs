using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject GameManagerPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!FindObjectOfType<GameManager>()) {
	        GameObject.Instantiate(GameManagerPrefab);
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
