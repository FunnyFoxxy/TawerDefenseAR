using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class moving : MonoBehaviour
{
    GameObject Tawer;
    GameObject pla;
    private NavMeshAgent behavior;
    public static Vector3 post;
    // Start is called before the first frame update
    void Start()
    {
       
        
     
    }

    // Update is called once per frame
    void Update()
    { //NavMesh.
        Tawer = GameObject.FindGameObjectWithTag("Tawer");
        pla = GameObject.FindGameObjectWithTag("pla");
   
        pla.transform.position = Tawer.transform.position;
        IntelectCreeps.post = pla.transform.position;
        Spawnr.post = pla.transform.position;
       
    }
}
