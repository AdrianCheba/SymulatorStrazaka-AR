using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvL2Script : MonoBehaviour
{
    public string objName;

    public GameObject waz;
    public Text poziomU;
    public ParticleSystem ogien;
    public ParticleSystem woda;

    public Menu menu;
    public Text txt;
    public Text txt2;
    public GameObject gasnica;



    void Start()
    {

        waz = GameObject.FindGameObjectWithTag("waz");
        ogien = ogien.GetComponent<ParticleSystem>();
        woda = woda.GetComponent<ParticleSystem>();
        woda.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        poziomU = poziomU.GetComponent<Text>();
        poziomU.enabled = false;
        txt = txt.GetComponent<Text>();
        txt.enabled = false;   
        txt2 = txt2.GetComponent<Text>();
        txt2.enabled = false;
        menu = menu.GetComponent<Menu>();
        gasnica = GameObject.FindGameObjectWithTag("gasnica2");

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

                    case "waz":
                            waz.transform.position = new Vector3(100, 100, 100);
                            menu.flagaLvL2 = 1;
                        break;


                    case "hydrant":
                        if (menu.flagaLvL2 == 1)
                        {
                            waz.transform.localPosition = new Vector3(-5f, 0.01f, -0.5f);
                            menu.flagaLvL2 = 4;
                        }
                        break;

                        
                    case "ogien2":
                        if (menu.range > 999f)
                        {
                            if (menu.flagaLvL2 == 3)
                            {
                                ogien.startSize -= 0.18f;
                                woda.Play(true);

                                if (ogien.startSize <= 0)
                                {

                                    txt.enabled = true;
                                    menu.btHome.SetActive(isActiveAndEnabled);
                                    menu.btHome2.SetActive(false);
                                    menu.btEq.SetActive(false);

                                }
                            }
                            txt2.enabled = false;
                        }else
                        {
                                txt2.enabled = true;

                          
                        }
                        break;

                    case "gasnica2":
                        menu.flagaLvL2 = 3;
                        gasnica.transform.position = new Vector3(100, 100, 100);
                        break;
                }
            }
        }
    }


}
