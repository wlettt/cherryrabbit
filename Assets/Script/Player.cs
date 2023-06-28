using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float veloc  ;
    public float entradaHorizontal;
    public float entradaVertical;


    public bool possoDarDisparoTriplo = false ;

    public GameObject pfLaser;
    public GameObject _disparoTriploPrefab;


    public  float tempoDeDisparo = 0.3f;
    public float podeDisparar = 0.0f;





    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Método Start de "+this.name);
        veloc = 3.0f;
        transform.position = new Vector3(0,0,0);

    }

    // Update is called once per frame
    void Update()
    {
       
        Movimento();

        if ( Input.GetKeyDown(KeyCode.Space)){

            if ( Time.time > podeDisparar ){
                if ( possoDarDisparoTriplo == true ){
                      Instantiate(_disparoTriploPrefab,transform.position + new Vector3(0,1.1f,0),Quaternion.identity);
                } else {
                    Instantiate(pfLaser,transform.position + new Vector3(0,1.1f,0),Quaternion.identity);
                }
                podeDisparar = Time.time + tempoDeDisparo ; 
            }
          
        }


    }


    private void Movimento(){

        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * veloc * Time.deltaTime * entradaHorizontal );

        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * veloc * Time.deltaTime * entradaVertical );

        if ( transform.position.y > 3.89f ) {
            transform.position = new Vector3(transform.position.x,3.89f,0);
        }

        if ( transform.position.y < -3.89f){
            transform.position = new Vector3(transform.position.x,-3.89f,0);
        }

        if ( transform.position.x > -7.94f){
            transform.position = new Vector3(-7.94f,transform.position.y,0);
        }

         if ( transform.position.x < -7.94f){
            transform.position = new Vector3(-7.94f,transform.position.y,0);
        } 

    }
}
