using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Spawner spawner;
    void Start()
    {
       spawner.active = false; 
    }
    void Awake()
    {
        spawner = GameObject.Find("Spawner").GameComponent<Spawner>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            spawner.active = true;
        }
    }
}