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
    public GameObject LvL1;
    public GameObject LvL2;
    public GameObject LvL3;
    public GameObject LvL4;
    public GameObject cos;
    Vector3 cosPos;
    public Text poziomU;

    public int flagaLvL1 = 0;
    public int flagaLvL2 = 0;
    public int flagaLvL3 = 0;

    public GameObject dysza;
    Vector3 dyszaPos;

    public float range = 1000f;

    public Image stanGasnicy;
    public float iloscPiany = 5f;
    public float czasGaszenia;

    public GameObject btHome;
    public GameObject btHome2;
    public GameObject btEq;

    void Start()
    {
        mainMenu = mainMenu.GetComponent<Canvas>();
        LvLMenu = LvLMenu.GetComponent<Canvas>();
        eq = eq.GetComponent<Canvas>();
        BtnEQ = BtnEQ.GetComponent<Canvas>();
       
        Time.timeScale = 0;

        LvLMenu.enabled = false;
        eq.enabled = false;
        BtnEQ.enabled = false;

        LvL1 = GameObject.FindGameObjectWithTag("LvL1");

        LvL2 = GameObject.FindGameObjectWithTag("LvL2");
        LvL2.SetActive(false); 
        
        LvL3 = GameObject.FindGameObjectWithTag("LvL3");
        LvL3.SetActive(false);
        
        LvL4 = GameObject.FindGameObjectWithTag("LvL4");
        LvL4.SetActive(false);

        cos = GameObject.FindGameObjectWithTag("cos");
        cosPos = cos.transform.position;
        cos.transform.position = new Vector3(cosPos.x + 0.043f, cosPos.y - 0.042f, cosPos.z + 0.11f);
        cos.SetActive(false);

        dysza = GameObject.FindGameObjectWithTag("dysza");
        dyszaPos = dysza.transform.position;
        dysza.transform.position = new Vector3(dyszaPos.x + 0.043f, dyszaPos.y - 0.042f, dyszaPos.z + 0.11f);
        dysza.SetActive(false);

        poziomU = poziomU.GetComponent<Text>();
        poziomU.enabled = false;

        stanGasnicy = stanGasnicy.GetComponent<Image>();
        stanGasnicy.enabled = false;

        czasGaszenia = iloscPiany;

        btHome = GameObject.FindGameObjectWithTag("btnHome");
        btHome.SetActive(false);

        btHome2 = GameObject.FindGameObjectWithTag("btnHome2");
        btEq = GameObject.FindGameObjectWithTag("btnEq");

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
        LvL2.SetActive(false);
        LvL3.SetActive(false);
        LvL4.SetActive(false);
        Time.timeScale = 1;
    }

    public void btnLvL2()
    {
        LvLMenu.enabled = false;
        BtnEQ.enabled = true;
        LvL1.SetActive(false);
        LvL3.SetActive(false);
        LvL4.SetActive(false);
        LvL2.SetActive(isActiveAndEnabled);

        Time.timeScale = 1;

    }    
    
    public void btnLvL3()
    {
        LvLMenu.enabled = false;
        BtnEQ.enabled = true;
        LvL1.SetActive(false);
        LvL2.SetActive(false);
        LvL4.SetActive(false);
        LvL3.SetActive(isActiveAndEnabled);

        Time.timeScale = 1;

    }   
    
    public void btnLvL4()
    {
        LvLMenu.enabled = false;
        BtnEQ.enabled = true;
        LvL1.SetActive(false);
        LvL2.SetActive(false);
        LvL3.SetActive(false);
        LvL4.SetActive(isActiveAndEnabled);

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
            eq.enabled = false;
            flagaLvL1 = 3;
            flagaLvL2 = 4;
            range = 900f;
            stanGasnicy.enabled = true;
        }
    }

    public void btnWaz()
    {
        if (flagaLvL2 == 4)
        {
            dysza.SetActive(true);
            cos.SetActive(false);
            eq.enabled = false;
            range = 1000f;
            flagaLvL2 = 3;
            stanGasnicy.enabled = false;
        }
    }

    public void aktualizacjaPaskaPiany()
    {
        if (czasGaszenia > -0.5f)
        {
            czasGaszenia -= Time.deltaTime;
        }

        if(iloscPiany != null)
        {
            stanGasnicy.fillAmount = czasGaszenia / iloscPiany;
        }
    }

    public void btnHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
