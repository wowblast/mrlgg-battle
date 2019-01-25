using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {

	// Use this for initialization
	public void volver()
    {
        SceneManager.LoadScene(0);
    }
    public void jugar()
    {
        SceneManager.LoadScene(2);
    }
    public void salir()
    {
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
