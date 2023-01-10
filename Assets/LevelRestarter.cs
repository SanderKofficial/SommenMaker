using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRestarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        print("Nieuwe Som Gegenereerd!");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    

    


}
