using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCherry : MonoBehaviour
{
    public float velocLaser = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * velocLaser * Time.deltaTime );

        if (transform.position.x > 10.0f){

            Destroy(this.gameObject);
        }
    }
}
