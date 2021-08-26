using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Canvas mainMenu;
    public Canvas LvLMenu;
    public Canvas eq;
    public Canvas BtnEQ;
    public Canvas LvL4Menu;
    public Canvas Wlasne;
    public GameObject LvL1;
    public GameObject LvL2;
    public GameObject LvL3;
    public GameObject LvL4;
    public GameObject LvL4E;
    public GameObject LvL4M;
    public GameObject LvL4H;
    public GameObject ogienLvL4;
    public GameObject ogienLvL42;
    public GameObject ogienLvL43;
    public GameObject ogienLvL44;
    public GameObject ogienLvL45;
    public GameObject ogienLvL46;
    public GameObject ogienLvL47;
    public GameObject ogienLvL48;
    public GameObject ogienLvL49;
    public GameObject ogienLvL410;
    public GameObject ogienLvL411;
    public GameObject cos;
    public GameObject gaP;
    Vector3 cosPos;
    Vector3 gaPPos;
    public Text poziomU;
    public Text brakCzasu;
    public Button UP;
    public Button Down;

    public int flagaLvL1 = 0;
    public int flagaLvL2 = 0;
    public int flagaLvL3 = 0;
    public int flagaLvL4 = 0;

    public GameObject dysza;
    Vector3 dyszaPos;

    public float range = 980f;

    public Image stanGasnicy;
    public Image stanGasnicy2;
    public float iloscPiany = 5f;
    public float iloscPiany2 = 5f;
    public float czasGaszenia;
    public float czasGaszenia2;

    public GameObject btHome;
    public GameObject btHome2;
    public GameObject btEq;

    public LvL4WScript l4WS;
    public LvL4Script l4S;

    Vector3 ga;
    Vector3 gP;
    Vector3 dysz;

    void Start()
    {
        Time.timeScale = 0;
        mainMenu = mainMenu.GetComponent<Canvas>();
        LvLMenu = LvLMenu.GetComponent<Canvas>();
        eq = eq.GetComponent<Canvas>();
        BtnEQ = BtnEQ.GetComponent<Canvas>();
        LvL4Menu = LvL4Menu.GetComponent<Canvas>();
        Wlasne = Wlasne.GetComponent<Canvas>();

        LvLMenu.enabled = false;
        eq.enabled = false;
        BtnEQ.enabled = false;
        LvL4Menu.enabled = false;
        Wlasne.enabled = false;

        LvL1 = GameObject.FindGameObjectWithTag("LvL1");
        LvL1.SetActive(false);

        LvL2 = GameObject.FindGameObjectWithTag("LvL2");
        LvL2.SetActive(false); 
        
        LvL3 = GameObject.FindGameObjectWithTag("LvL3");
        LvL3.SetActive(false);

        LvL4E = GameObject.FindGameObjectWithTag("LvL4E");
        LvL4E.SetActive(false);
        
        LvL4M = GameObject.FindGameObjectWithTag("LvL4M");
        LvL4M.SetActive(false); 
        
        LvL4H = GameObject.FindGameObjectWithTag("LvL4H");
        LvL4H.SetActive(false);

        ogienLvL4 = GameObject.Find("O1");
        ogienLvL42 = GameObject.Find("O2");
        ogienLvL43 = GameObject.Find("O3");
        ogienLvL44 = GameObject.Find("O4");
        ogienLvL45 = GameObject.Find("O5");
        ogienLvL46 = GameObject.Find("O6");
        ogienLvL47 = GameObject.Find("O7");
        ogienLvL48 = GameObject.Find("O8");
        ogienLvL49 = GameObject.Find("O9");
        ogienLvL410 = GameObject.Find("O10");
        ogienLvL411 = GameObject.Find("O11");

        LvL4 = GameObject.FindGameObjectWithTag("LvL4");
        LvL4.SetActive(false);

        cos = GameObject.FindGameObjectWithTag("cos");
        cosPos = cos.transform.position;
        cos.transform.position = new Vector3(cosPos.x + 0.043f, cosPos.y - 0.042f, cosPos.z + 0.11f);
        cos.SetActive(false); 
        
        gaP = GameObject.FindGameObjectWithTag("gaP");
        gaPPos = gaP.transform.position;
        gaP.transform.position = new Vector3(gaPPos.x + 0.043f, gaPPos.y - 0.042f, gaPPos.z + 0.11f);
        gaP.SetActive(false);

        dysza = GameObject.FindGameObjectWithTag("dysza");
        dyszaPos = dysza.transform.position;
        dysza.transform.position = new Vector3(dyszaPos.x + 0.043f, dyszaPos.y - 0.042f, dyszaPos.z + 0.11f);
        dysza.SetActive(false);

        poziomU = poziomU.GetComponent<Text>();
        poziomU.enabled = false;

        stanGasnicy = stanGasnicy.GetComponent<Image>();
        stanGasnicy.enabled = false;
        
        stanGasnicy2 = stanGasnicy2.GetComponent<Image>();
        stanGasnicy2.enabled = false;

        czasGaszenia = iloscPiany;
        czasGaszenia2 = iloscPiany2;

        btHome = GameObject.FindGameObjectWithTag("btnHome");
        btHome.SetActive(false);

        btHome2 = GameObject.FindGameObjectWithTag("btnHome2");
        btEq = GameObject.FindGameObjectWithTag("btnEq");

        brakCzasu = brakCzasu.GetComponent<Text>();
        brakCzasu.enabled = false;

        UP = UP.GetComponent<Button>();
        Down = Down.GetComponent<Button>();

        UP.gameObject.SetActive(false);
        Down.gameObject.SetActive(false);
        l4S.Lczas.enabled = false;

    }


    private void Update()
    {
        ga = cos.transform.localRotation.eulerAngles;
        gP = gaP.transform.localRotation.eulerAngles;
        dysz = dysza.transform.localRotation.eulerAngles;

    }

    public void btnStart()
    {
        mainMenu.enabled = false;
        LvLMenu.enabled = true;
        
    }
   
    public void btnLvL1()
    {
        LvLMenu.enabled = false;
        BtnEQ.enabled = true; 
        LvL1.SetActive(isActiveAndEnabled);
        Time.timeScale = 1;
    }

    public void btnLvL2()
    {
        LvLMenu.enabled = false;
        BtnEQ.enabled = true;
        LvL2.SetActive(isActiveAndEnabled);

        Time.timeScale = 1;

    }    
    
    public void btnLvL3()
    {
        LvLMenu.enabled = false;
        BtnEQ.enabled = true;
        LvL3.SetActive(isActiveAndEnabled);

        Time.timeScale = 1;

    }   
    
    public void btnLvL4()
    {
        LvLMenu.enabled = false;
        LvL4Menu.enabled = true;
        
    } 
    
    public void btnLvL4E()
    {
        LvL4Menu.enabled = false;
        BtnEQ.enabled = true;
        LvL4.SetActive(isActiveAndEnabled);
        LvL4E.SetActive(isActiveAndEnabled); 
        ogienLvL42.SetActive(isActiveAndEnabled);
        ogienLvL44.SetActive(isActiveAndEnabled);
        ogienLvL45.SetActive(isActiveAndEnabled);
        ogienLvL46.SetActive(isActiveAndEnabled);

        l4S.btnGP.gameObject.SetActive(false);
        l4S.btnW.gameObject.SetActive(false);
        l4S.btnGZ.gameObject.SetActive(false);

        l4WS.czas = 120f;
        l4WS.lczas = l4WS.czas;
        l4WS.timerTxt.enabled = true;
        l4WS.iloscZ = 4;
        Time.timeScale = 1;

    }    

    public void btnLvL4M()
    {
        LvL4Menu.enabled = false;
        BtnEQ.enabled = true;
        LvL4.SetActive(isActiveAndEnabled);
        LvL4M.SetActive(isActiveAndEnabled);
        ogienLvL4.SetActive(isActiveAndEnabled);
        ogienLvL42.SetActive(isActiveAndEnabled);
        ogienLvL43.SetActive(isActiveAndEnabled);
        ogienLvL44.SetActive(isActiveAndEnabled);
        ogienLvL45.SetActive(isActiveAndEnabled);
        ogienLvL46.SetActive(isActiveAndEnabled);
        ogienLvL47.SetActive(isActiveAndEnabled);
        ogienLvL49.SetActive(isActiveAndEnabled);
        ogienLvL411.SetActive(isActiveAndEnabled);

        l4S.btnGP.gameObject.SetActive(false);
        l4S.btnW.gameObject.SetActive(false);
        l4S.btnGZ.gameObject.SetActive(false);

        l4WS.czas = 90f;
        l4WS.lczas = l4WS.czas;
        l4WS.timerTxt.enabled = true;
        l4WS.iloscZ = 9;
        Time.timeScale = 1;

    }

    public void btnLvL4H()
    {
        LvL4Menu.enabled = false;
        BtnEQ.enabled = true;
        LvL4.SetActive(isActiveAndEnabled);
        LvL4H.SetActive(isActiveAndEnabled);
        ogienLvL4.SetActive(isActiveAndEnabled);
        ogienLvL42.SetActive(isActiveAndEnabled);
        ogienLvL43.SetActive(isActiveAndEnabled);
        ogienLvL44.SetActive(isActiveAndEnabled);
        ogienLvL45.SetActive(isActiveAndEnabled);
        ogienLvL46.SetActive(isActiveAndEnabled);
        ogienLvL47.SetActive(isActiveAndEnabled);
        ogienLvL48.SetActive(isActiveAndEnabled);
        ogienLvL49.SetActive(isActiveAndEnabled);
        ogienLvL410.SetActive(isActiveAndEnabled);
        ogienLvL411.SetActive(isActiveAndEnabled);

        l4S.btnGP.gameObject.SetActive(false);
        l4S.btnW.gameObject.SetActive(false);
        l4S.btnGZ.gameObject.SetActive(false);

        l4WS.czas = 75f;
        l4WS.lczas = l4WS.czas;
        l4WS.timerTxt.enabled = true;
        l4WS.iloscZ = 11;
        Time.timeScale = 1;

    }   
    

    public void btnEq()
    {
        if (eq.enabled == false)
        {
            eq.enabled = true;
        }
        else
        {
            eq.enabled = false;
        }
    }

    public void btnGasnica()
    {
        if (flagaLvL1 == 2 || flagaLvL2 == 3 || flagaLvL3 == 5)
        {
            cos.SetActive(isActiveAndEnabled);
            dysza.SetActive(false);
            gaP.SetActive(false);
            eq.enabled = false;
            flagaLvL1 = 3;
            flagaLvL2 = 4;
            range = 900f;
            stanGasnicy.enabled = true;

            UP.gameObject.SetActive(isActiveAndEnabled);
            Down.gameObject.SetActive(isActiveAndEnabled);
        }
    }    
    
    public void btnGasnicaP()
    {
        if (flagaLvL4 == 0)
        {
            gaP.SetActive(isActiveAndEnabled);
            dysza.SetActive(false);
            cos.SetActive(false);
            eq.enabled = false;
            range = 900f;
            stanGasnicy2.enabled = true;
            UP.gameObject.SetActive(isActiveAndEnabled);
            Down.gameObject.SetActive(isActiveAndEnabled);
        }
    }

    public void btnWaz()
    {
        if (flagaLvL2 == 4 || flagaLvL4 == 0)
        {
            dysza.SetActive(true);
            cos.SetActive(false);
            gaP.SetActive(false);
            eq.enabled = false;
            range = 1000f;
            flagaLvL2 = 3;
            stanGasnicy.enabled = false;
            UP.gameObject.SetActive(isActiveAndEnabled);
            Down.gameObject.SetActive(isActiveAndEnabled);
        }
    }

    public void aktualizacjaPaskaPiany()
    {
        if (czasGaszenia > -0.5f)
        {
            czasGaszenia -= Time.deltaTime;
        }

        if(iloscPiany != 0)
        {
            stanGasnicy.fillAmount = czasGaszenia / iloscPiany;
        }
    }   
    
    public void aktualizacjaPaskaPiany2()
    {
        if (czasGaszenia2 > -0.5f)
        {
            czasGaszenia2 -= Time.deltaTime;
        }

        if(iloscPiany2 != 0)
        {
            stanGasnicy2.fillAmount = czasGaszenia2 / iloscPiany2;
        }
    }

    public void btnHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void btnPowrotLvL4()
    {
        LvL4Menu.enabled = false;
        LvLMenu.enabled = true;
    }    
    public void btnPowrotWlasne()
    {
        LvL4Menu.enabled = true;
        Wlasne.enabled = false;
    }

    public void btnUp()
    {
        if (cos.activeInHierarchy == true)
        {
            cos.transform.localRotation = Quaternion.Euler(ga.x - 1.5f, ga.y, ga.z);
            range += 10;
        }
        if (gaP.activeInHierarchy == true)
        {
            gaP.transform.localRotation = Quaternion.Euler(gP.x - 1.5f, gP.y, gP.z);
            range += 10;
        }
        if (dysza.activeInHierarchy == true)
        {
            dysza.transform.localRotation = Quaternion.Euler(dysz.x, dysz.y, dysz.z - 1.5f);
            range += 20;
        }
        
    }  
    
    public void btnDown()
    {
        if (cos.activeInHierarchy == true)
        { 
           cos.transform.localRotation = Quaternion.Euler(ga.x + 1.5f, ga.y, ga.z);
            range -= 10;
        }
        if (gaP.activeInHierarchy == true)
        {
            gaP.transform.localRotation = Quaternion.Euler(gP.x + 1.5f, gP.y, gP.z);
            range -= 10;
        }

        if (dysza.activeInHierarchy == true)
        { 
            dysza.transform.localRotation = Quaternion.Euler(dysz.x, dysz.y, dysz.z + 1.5f);
            range -= 20;
        }

    }
}
