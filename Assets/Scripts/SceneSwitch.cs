using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        
    }

    public void EarthScene(){
    	Debug.Log("Hello World");
    	SceneManager.LoadScene("EarthScene");
    }

    public void Galaxy(){
		Debug.Log("Hello World");
    	SceneManager.LoadScene("SampleScene");
    }
    // Debug.Log("Hello World");
}
