using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LvL1_RayCasts : MonoBehaviour
{
    
    string objName;

    public GameObject gasnica;

    public ParticleSystem ogien;
    public ParticleSystem woda;

    
    public Text poziomU;
    public Text odlegloscGasnica;
    public  Menu menu;

    void Start()
    {
        gasnica = GameObject.FindGameObjectWithTag("gasnica");
        ogien = ogien.GetComponent<ParticleSystem>();
        woda = woda.GetComponent<ParticleSystem>();
        woda.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);

        menu = menu.GetComponent<Menu>();
      

        poziomU = poziomU.GetComponent<Text>();
        odlegloscGasnica = odlegloscGasnica.GetComponent<Text>();
        poziomU.enabled = false;
        odlegloscGasnica.enabled = false;

       

    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Stationary)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit, menu.range))
            {

                objName = Hit.transform.tag;
                switch (objName)
                {

                    case "gasnica":
                        gasnica.transform.position = new Vector3(100, 100, 100);
                        menu.flagaLvL1 = 2;
                    break;

                    case "ogien":
                        if (menu.flagaLvL1 == 3)

                            if (menu.czasGaszenia >= -0.5)
                            {
                                ogien.startSize -= 0.1f;
                                woda.Play(true);
                                menu.aktualizacjaPaskaPiany();
                            }


                        if(ogien.startSize <= 0)
                        {
                            poziomU.enabled = true;
                            menu.btHome.SetActive(isActiveAndEnabled);
                            menu.btHome2.SetActive(false);
                            menu.btEq.SetActive(false);
                        }
                    break;
                }
            }
        }

    }

}
