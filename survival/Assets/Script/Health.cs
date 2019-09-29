using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Health : MonoBehaviour
{
	public GameObject musica1, musica2,musica3,generadores;
	public static bool start = false;
	public static bool activos = true;
	public static int currentHealth = 1000;
	public int internalhealth;
	public Text vida;
	public Text tiempo;
	public float time = 300.0f;
	public GameObject panel;
	public RawImage burbuja;
    public RawImage deathblossom;
    public GameObject fpsplayer;
    public GameObject pj;
	public GameObject escudo;
	public Texture burbujaa;
	public Texture noburbuja;
    public Texture death;
	public bool poder = true;
    public bool poder2 = true;
	bool tiempopoder = true;
    bool tiempopoder2 = true;
	bool act = false;
    bool act2 = false;
	int cnt = 0;
    public float target_distance;
    public Camera camera1;
    public Camera camera2;
    float x =1 ;
    // Use this for initialization
    void Start()
	{
		x = 1;
        currentHealth = 1000;
		burbuja.texture = burbujaa;
        deathblossom.texture = death;
        camera1.enabled = true;
        camera2.enabled = false;
	}

	// Update is called once per frame
	void Update()
	{
		if(currentHealth<=150&&cnt==0)
		{
			cnt++;
			StartCoroutine(Salvation());

		}
		if(Input.GetKey("f")&&poder)
		{
			/*poder = false;
			act = false;
			tiempopoder = false;
			StartCoroutine(Firingpistol());
			burbuja.texture = noburbuja;
			StartCoroutine(burbujactiva());*/
			power();
		}
		if(Input.GetKey("x"))			
			power2();
		

		internalhealth = currentHealth;
		// rest-=Tar((int)Time.deltaTime);
		time -= Time.deltaTime;

		if (!tiempopoder)
		{
			if (!act)
			{
              
				StartCoroutine(burble());
			}
		}
		if (time <= 0)
		{
			SceneManager.LoadScene(3);
		}
		restar(int.Parse(time.ToString("f0")));
		// tiempo.text = time.ToString("F0");
        if(!tiempopoder2)
        {
            if(!act2)
            {
				
				

//pj.transform.RotateAround(pj.transform.position, Vector3.back, 40 * Time.deltaTime);
                StartCoroutine(deathpower());
            }
        }
		if (currentHealth <= 0)
		{
			SceneManager.LoadScene(1);
		}
		vida.text = "Health: " + currentHealth;
	}

	void restar(int tsegundos)
	{


		int horas = (tsegundos / 3600);
		int minutos = ((tsegundos - horas * 3600) / 60);
		int segundos = tsegundos - (horas * 3600 + minutos * 60);
		tiempo.text = "Resiste por "+horas.ToString() + ":" + minutos.ToString() + ":" + segundos.ToString();
	}
	
	IEnumerator Firingpistol()
	{
		yield return new WaitForSeconds(15.0f);

		poder = true;
		burbuja.texture = burbujaa;

	}
	IEnumerator burble()
	{
		act = true;
		
		currentHealth += 40;
		yield return new WaitForSeconds(2.0f);
		act = false;
		//currentHealth += 5;
		

	}
	
    IEnumerator firepistol2()
    {
        yield return new WaitForSeconds(8.0f);
        camera1.enabled = true;
        camera2.enabled = false;
        tiempopoder2 = true;
		escudo.SetActive(false);


	}
	IEnumerator Salvation()
	{
		activos = false;
		musica2.SetActive(false);
		musica1.SetActive(false);
		musica3.SetActive(true);
		generadores.SetActive(false);
		yield return new WaitForSeconds((60*3)+35f);
		musica1.SetActive(true);
		musica3.SetActive(false);
		musica2.SetActive(false);
		activos = true;
		generadores.SetActive(true);
		ActivateGenerators();
		


	}
	IEnumerator deathpower()
    {
		escudo.transform.RotateAround(pj.transform.position, Vector3.down, 100);
		//Debug.Log(x);
		//x += 0.0001f;
		//pj.GetComponent<FirstPersonController>().m_MouseLook.LookAxis = new Vector2(0, x); 


		
		RaycastHit shot;
        act2 = true;
        if (Physics.Raycast(fpsplayer.transform.position, fpsplayer.transform.TransformDirection(Vector3.forward), out shot))
        {
            
            target_distance = shot.distance;
          shot.transform.SendMessage("Damageminion", 20, SendMessageOptions.DontRequireReceiver);
        }
		if (Physics.Raycast(fpsplayer.transform.position, fpsplayer.transform.TransformDirection(Vector3.down), out shot))
		{

			target_distance = shot.distance;
			shot.transform.SendMessage("Damageminion", 20, SendMessageOptions.DontRequireReceiver);
		}
		if (Physics.Raycast(fpsplayer.transform.position, fpsplayer.transform.TransformDirection(Vector3.up), out shot))
        {

            target_distance = shot.distance;
            shot.transform.SendMessage("Damageminion", 20, SendMessageOptions.DontRequireReceiver);
        }
        if (Physics.Raycast(fpsplayer.transform.position, fpsplayer.transform.TransformDirection(Vector3.left), out shot))
        {

            target_distance = shot.distance;
            shot.transform.SendMessage("Damageminion", 20, SendMessageOptions.DontRequireReceiver);
        }
        if (Physics.Raycast(fpsplayer.transform.position, fpsplayer.transform.TransformDirection(Vector3.right), out shot))
        {

            target_distance = shot.distance;
            shot.transform.SendMessage("Damageminion", 20, SendMessageOptions.DontRequireReceiver);
        }
        if (Physics.Raycast(fpsplayer.transform.position, fpsplayer.transform.TransformDirection(Vector3.back), out shot))
        {

            target_distance = shot.distance;
            shot.transform.SendMessage("Damageminion", 20, SendMessageOptions.DontRequireReceiver);
        }
		if (Physics.Raycast(fpsplayer.transform.position, fpsplayer.transform.TransformDirection(new Vector3(1,1,0)), out shot))
		{

			target_distance = shot.distance;
			shot.transform.SendMessage("Damageminion", 20, SendMessageOptions.DontRequireReceiver);
		}
		if (Physics.Raycast(fpsplayer.transform.position, fpsplayer.transform.TransformDirection(new Vector3(-1, -1, 0)), out shot))
		{

			target_distance = shot.distance;
			shot.transform.SendMessage("Damageminion", 20, SendMessageOptions.DontRequireReceiver);
		}
		if (Physics.Raycast(fpsplayer.transform.position, fpsplayer.transform.TransformDirection(new Vector3(1, -1, 0)), out shot))
		{

			target_distance = shot.distance;
			shot.transform.SendMessage("Damageminion", 20, SendMessageOptions.DontRequireReceiver);
		}
		if (Physics.Raycast(fpsplayer.transform.position, fpsplayer.transform.TransformDirection(new Vector3(-1, 1, 0)), out shot))
		{

			target_distance = shot.distance;
			shot.transform.SendMessage("Damageminion", 20, SendMessageOptions.DontRequireReceiver);
		}



		//currentHealth += 0.1;
		yield return new WaitForSeconds(0.01f);
        act2 = false;
        //currentHealth += 5;


    }
    IEnumerator burbujactiva()
    {
        panel.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        panel.SetActive(false);
        tiempopoder = true;
        //currentHealth += 5;


    }
	IEnumerator Poder2activo()
	{
	//	panel.SetActive(true);

		yield return new WaitForSeconds(15.0f);
		deathblossom.texture = death;
		poder2 = true;
	
		//currentHealth += 5;


	}
	public void power()
    {
        if (poder)
        {
            poder = false;
            act = false;
            tiempopoder = false;
            StartCoroutine(Firingpistol());
            burbuja.texture = noburbuja;
            StartCoroutine(burbujactiva());
        }
    }
    public void power2()
    {
        
        if (poder2)
        {
			escudo.SetActive(true);
			x = 1;
			camera1.enabled = false;
            camera2.enabled = true;
            poder2 = false;
            act2 = false;
            tiempopoder2 = false;
            StartCoroutine(firepistol2());
			StartCoroutine(Poder2activo());

			deathblossom.texture = noburbuja;
           
        }
    }
	void ActivateGenerators()
	{
		
		Generatos.couroutineStarted = false;
		Generadorelemental.couroutineStarted = false;
		Generadorface.couroutineStarted = false;
		Generadornerubian.couroutineStarted = false;
		boss1generator.couroutineStarted = false;
		generadorboss2.couroutineStarted = false;
		generadorboss3.couroutineStarted = false;
		generadorboss4.couroutineStarted = false;
		generadorm1.couroutineStarted = false;
		generadorm2.couroutineStarted = false;
		generadorm3.couroutineStarted = false;
		generadorm4.couroutineStarted = false;



		



	}
}
