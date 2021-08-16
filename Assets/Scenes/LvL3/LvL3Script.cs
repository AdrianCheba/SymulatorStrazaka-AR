using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvL3Script : MonoBehaviour
{
    string objName;

    public GameObject gasnica;
    public GameObject gasnicaP;
    public GameObject waz;

    public ParticleSystem ogien;
    public ParticleSystem woda;

    public Menu menu;
    public Text txt;
    public Text txt2;


    void Start()
    {
        waz = GameObject.FindGameObjectWithTag("waz2");
        ogien = ogien.GetComponent<ParticleSystem>();
        woda = woda.GetComponent<ParticleSystem>();
        woda.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        txt = txt.GetComponent<Text>();
        txt.enabled = false;
        txt2 = txt2.GetComponent<Text>();
        txt2.enabled = false;
        menu = menu.GetComponent<Menu>();
        gasnica = GameObject.FindGameObjectWithTag("gasnica3");
        gasnicaP = GameObject.FindGameObjectWithTag("gasnicaP");
    }

   
    void Update()
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

                    case "waz2":
                        waz.transform.position = new Vector3(100, 100, 100);
                        break;


                    case "hydrant2":
                            waz.transform.localPosition = new Vector3(-5f, 0.01f, -0.5f);

                        break;
                        

                    case "elektryka":
                       
                            if (menu.flagaLvL3 == 5)
                            {
                                 if (menu.czasGaszenia >= -0.5)
                                 {
                                    ogien.startSize -= 0.007f;
                                    woda.Play(true);
                                    menu.aktualizacjaPaskaPiany();

                                    if (ogien.startSize <= 0)
                                    {

                                    txt.enabled = true;
                                    menu.btHome.SetActive(isActiveAndEnabled);
                                    menu.btHome2.SetActive(false);
                                    menu.btEq.SetActive(false);

                                    }
                                 }
                                     txt2.enabled = false;
                            }
                            else
                            {
                                txt2.enabled = true;
                            }
                            break;

                    case "gasnica3":
                        gasnica.transform.position = new Vector3(100, 100, 100);
                        break;
                    
                    case "gasnicaP":
                        menu.flagaLvL3 = 5;
                        gasnicaP.transform.position = new Vector3(100, 100, 100);
                        break;
                }
            }
        }
    }
}
