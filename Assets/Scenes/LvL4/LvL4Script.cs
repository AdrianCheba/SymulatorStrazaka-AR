using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvL4Script : MonoBehaviour
{
    string objName;
    public Menu menu;

    public ParticleSystem woda;
    public ParticleSystem piana;
    public ParticleSystem proszek;

    public ParticleSystem O1;
    public ParticleSystem O2;
    public ParticleSystem O3;
    public ParticleSystem O4;
    public ParticleSystem O5;
    public ParticleSystem O6;
    public ParticleSystem O7;
    public ParticleSystem O8;
    public ParticleSystem O9;
    public ParticleSystem O10;
    public ParticleSystem O11;
    public ParticleSystem Oe1;
    public ParticleSystem Oe2;
    public ParticleSystem Oe3;

    public Text zlaGasnica;


    void Start()
    {

        piana = piana.GetComponent<ParticleSystem>();
        proszek = proszek.GetComponent<ParticleSystem>();
        woda = woda.GetComponent<ParticleSystem>();
        O1 = O1.GetComponent<ParticleSystem>();
        O2 = O2.GetComponent<ParticleSystem>();
        O3 = O3.GetComponent<ParticleSystem>();
        O4 = O4.GetComponent<ParticleSystem>();
        O5 = O5.GetComponent<ParticleSystem>();
        O6 = O6.GetComponent<ParticleSystem>();
        O7 = O7.GetComponent<ParticleSystem>();
        O8 = O8.GetComponent<ParticleSystem>();
        O9 = O9.GetComponent<ParticleSystem>();
        O10 = O10.GetComponent<ParticleSystem>();
        O11 = O11.GetComponent<ParticleSystem>();
        Oe1 = Oe1.GetComponent<ParticleSystem>();
        Oe2 = Oe2.GetComponent<ParticleSystem>();
        Oe3 = Oe3.GetComponent<ParticleSystem>();

        zlaGasnica = zlaGasnica.GetComponent<Text>();
        

    }


    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Stationary)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit, menu.range))
            {

                objName = Hit.transform.name;
                switch (objName)
                {
                    case "O1":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            O1.startSize -= 0.36f;
                            piana.Play(true);
                            menu.aktualizacjaPaskaPiany();
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O1.startSize -= 0.46f;
                            woda.Play(true);
                        }
                        break;
                    
                    case "O2":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            O2.startSize -= 0.36f;
                            piana.Play(true);
                            menu.aktualizacjaPaskaPiany();
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O2.startSize -= 0.46f;
                            woda.Play(true);
                        }
                        break;
                    
                    case "O3":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            O3.startSize -= 0.36f;
                            piana.Play(true);
                            menu.aktualizacjaPaskaPiany();
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O3.startSize -= 0.46f;
                            woda.Play(true);
                        }
                        break; 

                    case "O4":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            O4.startSize -= 0.36f;
                            piana.Play(true);
                            menu.aktualizacjaPaskaPiany();
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O4.startSize -= 0.46f;
                            woda.Play(true);
                        }
                        break;   
                    
                    case "O5":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            O5.startSize -= 0.36f;
                            piana.Play(true);
                            menu.aktualizacjaPaskaPiany();
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O5.startSize -= 0.46f;
                            woda.Play(true);
                        }
                        break; 
                    
                    case "O6":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            O6.startSize -= 0.40f;
                            piana.Play(true);
                            menu.aktualizacjaPaskaPiany();
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O6.startSize -= 0.50f;
                            woda.Play(true);
                        }
                        break;            
                                          
                    case "O7":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            O7.startSize -= 0.40f;
                            piana.Play(true);
                            menu.aktualizacjaPaskaPiany();
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O7.startSize -= 0.50f;
                            woda.Play(true);
                        }
                        break;            
                                          
                    case "O8":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            O8.startSize -= 0.40f;
                            piana.Play(true);
                            menu.aktualizacjaPaskaPiany();
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O8.startSize -= 0.50f;
                            woda.Play(true);
                        }
                        break;           
                                         
                    case "O9":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            O9.startSize -= 0.40f;
                            piana.Play(true);
                            menu.aktualizacjaPaskaPiany();
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O9.startSize -= 0.50f;
                            woda.Play(true);
                        }
                        break;
                    
                    case "O10":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            O10.startSize -= 0.40f;
                            piana.Play(true);
                            menu.aktualizacjaPaskaPiany();
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O10.startSize -= 0.50f;
                            woda.Play(true);
                        }
                        break;
                    
                    case "O11":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            O11.startSize -= 0.40f;
                            piana.Play(true);
                            menu.aktualizacjaPaskaPiany();
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O11.startSize -= 0.50f;
                            woda.Play(true);
                        }
                        break;
                    
                    case "OE1":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            Oe1.startSize -= 0.30f;
                            proszek.Play(true);
                            menu.aktualizacjaPaskaPiany();
                            zlaGasnica.enabled = false;
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            zlaGasnica.enabled = true;
                        }
                        break;
                    
                    case "OE2":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            Oe2.startSize -= 0.36f;
                            proszek.Play(true);
                            menu.aktualizacjaPaskaPiany();
                            zlaGasnica.enabled = false;
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            zlaGasnica.enabled = true;
                        }
                        break;
                    
                    case "OE3":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            Oe3.startSize -= 0.36f;
                            proszek.Play(true);
                            menu.aktualizacjaPaskaPiany();
                            zlaGasnica.enabled = false;
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            zlaGasnica.enabled = true;
                        }
                        break;
            }
            }
        }
    }
}
