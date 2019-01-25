using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggpoder : MonoBehaviour
{
	public GameObject luz,musica1,musica2;
	public static int nivel=1000;
	int vida = 10;
	int count = 0;
	void Damageminion(int damage)
	{
		
		vida-= damage;
	}
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(vida<=0&& count ==0)
		{
			count++;
			nivel = 500;
			//luz.transform.Rotate(-450, 0, 0);
			luz.SetActive(true);
			musica1.SetActive(false);
			musica2.SetActive(true);
		}
    }
}
