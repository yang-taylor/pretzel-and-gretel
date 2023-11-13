using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    [SerializeField] private string levelname;
    
    void OnTriggerEnter2D(Collider2D other)
        {
            // Get the game manager
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (levelname == "Cutscene1")
            {        
              gameManager.toCutscene1();
            }
            else if (levelname == "Outro") {
            	gameManager.toOutro();
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
