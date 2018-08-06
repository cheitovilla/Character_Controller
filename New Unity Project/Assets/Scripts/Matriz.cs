using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Matriz : MonoBehaviour {
    public bool star;
    public int rangocolor;
    public int rangoMatriz;
    Color colorR = Color.red;
    Color colorG = Color.green;
    Color colorB = Color.blue;
    Color colorY = Color.yellow;
    public bool play;
    
    

    // Use this for initialization
    void Start(){
        
    }

    void IniciarGame()
    {
        ArrayList list = new ArrayList();
        rangoMatriz = Random.Range(3, 13);
        for (int i = 0; i < rangoMatriz; i++)
        {
            for (int j = 0; j < rangoMatriz; j++)
            {
                GameObject bolas = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                bolas.transform.position = new Vector3(i * 2.0f, j * 2.0f, 0.0f);
                list.Add(bolas);
                rangocolor = Random.Range(0, 4);
                if (rangocolor == 0)
                {
                    bolas.GetComponent<Renderer>().material.color = colorR;
                }
                else if (rangocolor == 1)
                {
                    bolas.GetComponent<Renderer>().material.color = colorG;
                }
                else if (rangocolor == 2)
                {
                    bolas.GetComponent<Renderer>().material.color = colorB;
                }
                else if (rangocolor == 3)
                {
                    bolas.GetComponent<Renderer>().material.color = colorY;
                }
               
               
            }
        }
    }

    // Update is called once per frame
    void Update () {
        if (star)
        {
          //  Destroy(gameObject);
            IniciarGame();
            star = false;
        }
        if (play)
        {

        }
        
    }

           



}
