using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pium : MonoBehaviour
{
    public GameObject arma_bala;
    public Transform spauwpoint;
    public float force;
    public int carucho = 5;
    public int caruchomax;

    private void Start()
    {
        carucho = caruchomax;
    }


    private void Update()
    {
        if(Input.GetButtonDown("Fire1")&& carucho > 0)
        {
            GameObject newBullst = Instantiate(arma_bala, spauwpoint.position, spauwpoint.rotation);;
            newBullst.GetComponent<Rigidbody>().AddForce(newBullst.transform.forward * force, ForceMode.Impulse);
            Destroy(newBullst , 2f);
            carucho--;
            //shortRatetime = Time.time + shortRate;
            
                          
            

        }
        if (Input.GetButtonDown("Botton r"))
        {
            Reload();
        }


    }

    void Reload()
    {
        carucho = caruchomax;
    }
}
