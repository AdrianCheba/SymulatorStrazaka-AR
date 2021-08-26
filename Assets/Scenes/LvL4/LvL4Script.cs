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

    public GameObject wazLvL4;
    public GameObject gaP1;
    public GameObject gaP2;
    public GameObject gasnicaZ1;
    public GameObject gasnicaZ2;
    public Button btnW;
    public Button btnGZ;
    public Button btnGP;

    public Text zlaGasnica;
    public Text koniecGry;
    public Text koniecCzasu;
    public Text malyZasieg;
    public Text Lczas;

    public LvL4WScript l4WS;

    void Start()
    {

        wazLvL4 = GameObject.Find("wazLvL4");
        gaP1 = GameObject.Find("gaP1");
        gaP2 = GameObject.Find("gaP2");
        gasnicaZ1 = GameObject.Find("gasnicaZ1");
        gasnicaZ2 = GameObject.Find("gasnicaZ2");
        btnW = btnW.GetComponent<Button>();
        btnGZ = btnGZ.GetComponent<Button>();
        btnGP= btnGP.GetComponent<Button>();

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

        l4WS = l4WS.GetComponent<LvL4WScript>();
        zlaGasnica = zlaGasnica.GetComponent<Text>();
        koniecGry = koniecGry.GetComponent<Text>();
        koniecCzasu = koniecCzasu.GetComponent<Text>();
        koniecCzasu.enabled = false;

        malyZasieg = malyZasieg.GetComponent<Text>();
        Lczas = Lczas.GetComponent<Text>();
        Lczas.enabled = false;
    }


    void Update()
    {
        if(l4WS.czas <= 0.1f)
        {
            zlaGasnica.enabled = false;
            koniecCzasu.enabled = true;
            menu.btHome.SetActive(isActiveAndEnabled);
            menu.btHome2.SetActive(false);
            menu.btEq.SetActive(false);
            malyZasieg.enabled = false;
            menu.UP.gameObject.SetActive(false);
            menu.Down.gameObject.SetActive(false);
            Time.timeScale = 0;
        }

        if (menu.ogienLvL4.activeInHierarchy == false && menu.ogienLvL42.activeInHierarchy == false &&
            menu.ogienLvL43.activeInHierarchy == false && menu.ogienLvL44.activeInHierarchy == false &&
            menu.ogienLvL45.activeInHierarchy == false && menu.ogienLvL46.activeInHierarchy == false &&
            menu.ogienLvL47.activeInHierarchy == false && menu.ogienLvL48.activeInHierarchy == false &&
            menu.ogienLvL49.activeInHierarchy == false && menu.ogienLvL410.activeInHierarchy == false &&
            menu.ogienLvL411.activeInHierarchy == false 
            )
        {
            koniecGry.enabled = true;
            menu.btHome.SetActive(isActiveAndEnabled);
            menu.btHome2.SetActive(false);
            menu.btEq.SetActive(false);
            malyZasieg.enabled = false;
            zlaGasnica.enabled = false;
            menu.UP.gameObject.SetActive(false);
            menu.Down.gameObject.SetActive(false);
            Lczas.enabled = true;
            Lczas.text = "Czas akcji  " + ((int)l4WS.lczas - (int)l4WS.czas) + " s";

            Time.timeScale = 0;
        }

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
                            if (menu.czasGaszenia >= -0.5)
                            {
                                O1.startSize -= 0.36f;
                                piana.Play(true);
                                menu.aktualizacjaPaskaPiany();
                            }
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O1.startSize -= 0.46f;
                            woda.Play(true);
                        }

                        if(O1.startSize <= 0)
                        {
                            menu.ogienLvL4.SetActive(false);
                        }
                        malyZasieg.enabled = false;
                        break;
                    
                    case "O2":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            if (menu.czasGaszenia >= -0.5)
                            {
                                O2.startSize -= 0.36f;
                                piana.Play(true);
                                menu.aktualizacjaPaskaPiany();
                            }

                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O2.startSize -= 0.46f;
                            woda.Play(true);
                        }

                        if (O2.startSize <= 0)
                        {
                            menu.ogienLvL42.SetActive(false);
                        }
                        malyZasieg.enabled = false;
                        break;
                    
                    case "O3":
                        if (menu.range > 1000)
                        {
                            if (menu.cos.activeInHierarchy == true)
                            {
                                if (menu.czasGaszenia >= -0.5)
                                {
                                    O3.startSize -= 0.36f;
                                    piana.Play(true);
                                    menu.aktualizacjaPaskaPiany();
                                }
                            }
                            else if (menu.dysza.activeInHierarchy == true)
                            {
                                O3.startSize -= 0.46f;
                                woda.Play(true);
                            }

                            if (O3.startSize <= 0)
                            {
                                menu.ogienLvL43.SetActive(false);
                            }
                            malyZasieg.enabled = false;
                        }
                        else
                        {
                            malyZasieg.enabled = true;
                        }
                        break; 

                    case "O4":
                        if (menu.range > 1000)
                        {
                            if (menu.cos.activeInHierarchy == true)
                            {
                                if (menu.czasGaszenia >= -0.5)
                                {
                                    O4.startSize -= 0.36f;
                                    piana.Play(true);
                                    menu.aktualizacjaPaskaPiany();
                                }
                            }
                            else if (menu.dysza.activeInHierarchy == true)
                            {
                                O4.startSize -= 0.46f;
                                woda.Play(true);
                            }

                            if (O4.startSize <= 0)
                            {
                                menu.ogienLvL44.SetActive(false);
                            }
                            malyZasieg.enabled = false;
                        }
                        else
                        {
                            malyZasieg.enabled = true;
                        }
                        break;   
                    
                    case "O5":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            if (menu.czasGaszenia >= -0.5)
                            {
                                O5.startSize -= 0.36f;
                                piana.Play(true);
                                menu.aktualizacjaPaskaPiany();
                            }
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O5.startSize -= 0.46f;
                            woda.Play(true);
                        }

                        if (O5.startSize <= 0)
                        {
                            menu.ogienLvL45.SetActive(false);
                        }
                        malyZasieg.enabled = false;
                        break; 
                    
                    case "O6":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            if (menu.czasGaszenia >= -0.5)
                            {
                                O6.startSize -= 0.40f;
                                piana.Play(true);
                                menu.aktualizacjaPaskaPiany();
                            }
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O6.startSize -= 0.50f;
                            woda.Play(true);
                        }

                        if (O6.startSize <= 0)
                        {
                            menu.ogienLvL46.SetActive(false);
                        }
                        malyZasieg.enabled = false;
                        break;            
                                          
                    case "O7":
                        if (menu.range > 1000)
                        {
                            if (menu.cos.activeInHierarchy == true)
                            {
                                if (menu.czasGaszenia >= -0.5)
                                {
                                    O7.startSize -= 0.40f;
                                    piana.Play(true);
                                    menu.aktualizacjaPaskaPiany();
                                }
                            }
                            else if (menu.dysza.activeInHierarchy == true)
                            {
                                O7.startSize -= 0.50f;
                                woda.Play(true);
                            }

                            if (O7.startSize <= 0)
                            {
                                menu.ogienLvL47.SetActive(false);
                            }
                            malyZasieg.enabled = false;
                        }
                        else
                        {
                            malyZasieg.enabled = true;
                        }
                        break;            
                                          
                    case "O8":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            if (menu.czasGaszenia >= -0.5)
                            {
                                O8.startSize -= 0.40f;
                                piana.Play(true);
                                menu.aktualizacjaPaskaPiany();
                            }
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O8.startSize -= 0.50f;
                            woda.Play(true);
                        }

                        if(O8.startSize <= 0)
                        {
                            menu.ogienLvL48.SetActive(false);
                        }
                        malyZasieg.enabled = false;
                        break;           
                                         
                    case "O9":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            if (menu.czasGaszenia >= -0.5)
                            {
                                O9.startSize -= 0.40f;
                                piana.Play(true);
                                menu.aktualizacjaPaskaPiany();
                            }
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O9.startSize -= 0.50f;
                            woda.Play(true);
                        }

                         if(O9.startSize <= 0)
                        {
                            menu.ogienLvL49.SetActive(false);
                        }
                        malyZasieg.enabled = false;
                        break;
                    
                    case "O10":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            if (menu.czasGaszenia >= -0.5)
                            {
                                O10.startSize -= 0.40f;
                                piana.Play(true);
                                menu.aktualizacjaPaskaPiany();
                            }
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O10.startSize -= 0.50f;
                            woda.Play(true);
                        }

                        if (O10.startSize <= 0)
                        {
                            menu.ogienLvL410.SetActive(false);
                        }
                        malyZasieg.enabled = false;
                        break;
                    
                    case "O11":
                        if (menu.cos.activeInHierarchy == true)
                        {
                            if (menu.czasGaszenia >= -0.5)
                            {
                                O11.startSize -= 0.40f;
                                piana.Play(true);
                                menu.aktualizacjaPaskaPiany();
                            }
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            O11.startSize -= 0.50f;
                            woda.Play(true);
                        }

                        if (O11.startSize <= 0)
                        {
                            menu.ogienLvL411.SetActive(false);
                        }
                        malyZasieg.enabled = false;
                        break;
                    
                    case "OE1":
                        if (menu.gaP.activeInHierarchy == true)
                        {
                            if (menu.czasGaszenia2 >= -0.5)
                            {
                                Oe1.startSize -= 0.30f;
                                proszek.Play(true);
                                menu.aktualizacjaPaskaPiany2();
                                zlaGasnica.enabled = false;
                            }
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            zlaGasnica.enabled = true;
                        }
                        malyZasieg.enabled = false;
                        break;
                    
                    case "OE2":
                        if (menu.gaP.activeInHierarchy == true)
                        {
                            if (menu.czasGaszenia2 >= -0.5)
                            {
                                Oe2.startSize -= 0.36f;
                                proszek.Play(true);
                                menu.aktualizacjaPaskaPiany2();
                                zlaGasnica.enabled = false;
                            }
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            zlaGasnica.enabled = true;
                        }
                        malyZasieg.enabled = false;
                        break;
                    
                    case "OE3":
                        if (menu.gaP.activeInHierarchy == true)
                        {
                            if (menu.czasGaszenia2 >= -0.5)
                            {
                                Oe3.startSize -= 0.36f;
                                proszek.Play(true);
                                menu.aktualizacjaPaskaPiany2();
                                zlaGasnica.enabled = false;
                            }
                        }
                        else if (menu.dysza.activeInHierarchy == true)
                        {
                            zlaGasnica.enabled = true;
                        }
                        malyZasieg.enabled = false;
                        break;

                    case "wazLvL4":

                        wazLvL4.transform.position = new Vector3(100, 100, 100);
                        btnW.gameObject.SetActive(isActiveAndEnabled);
                        
                        break;
                    
                    case "gaP1":

                        gaP1.transform.position = new Vector3(100, 100, 100);
                        btnGP.gameObject.SetActive(isActiveAndEnabled);
                        menu.iloscPiany2 += 2f;

                        break;  
                        
                    case "gaP2":

                        gaP2.transform.position = new Vector3(100, 100, 100);
                        btnGP.gameObject.SetActive(isActiveAndEnabled);
                        menu.iloscPiany2 += 2f;
                        break;  
                    
                    case "gasnicaZ1":

                        gasnicaZ1.transform.position = new Vector3(100, 100, 100);
                        btnGZ.gameObject.SetActive(isActiveAndEnabled);
                        menu.iloscPiany += 2f;
                        break;    
                    
                    case "gasnicaZ2":

                        gasnicaZ2.transform.position = new Vector3(100, 100, 100);
                        btnGZ.gameObject.SetActive(isActiveAndEnabled);
                        menu.iloscPiany += 2f;
                        break;

                }
            }
        }
       
    }
}
