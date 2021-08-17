using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Spawner spawner;
    //public GameObject title;
    void Start()
    {
       spawner.active = false;
       //title.SetActive(true); 
    }
    void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            spawner.active = true;
            //title.SetActive(false);
        }
    }
}