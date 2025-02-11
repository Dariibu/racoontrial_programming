using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region parent
    public Sniper mySniper;
    [SerializeField] GameObject go_sniper;

    public Shorty myShorty;
    [SerializeField] GameObject go_shorty;
    #endregion

    [SerializeField] Gun currentGun;
    [SerializeField] ParticleSystem PS_Shoot;
    void Awake()
    {
        mySniper = new Sniper(1, 200, 0.2f, go_sniper);
        myShorty = new Shorty(3, 50, 1.5f, go_shorty);

        mySniper.PS_shooting = PS_Shoot;
        myShorty.PS_shooting = PS_Shoot;

        mySniper.cannon = mySniper.go.transform.GetChild(0);
        myShorty.cannon = myShorty.go.transform.GetChild(0);

        //mySniper.GetThisGun();
        //currentGun = mySniper;
    }
   /* void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && mySniper != currentGun) // el 1 va a ser el sniper
        {
            currentGun.RemoveThisGun();
            mySniper.GetThisGun();
            currentGun = mySniper;
            bullet = normalBullet;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && myShorty != currentGun) // el 2 va a ser la shorty
        {
            currentGun.RemoveThisGun();
            myShorty.GetThisGun();
            currentGun = myShorty;
            bullet = accumulatedBullet;
        }
        if (Input.GetKey(KeyCode.Mouse0) && CDTimer >= currentGun.CD) //si click, dispara
        {
            Debug.Log(currentGun);
            currentGun.Shoot(bullet, currentGun.Da�o);
            CDTimer = 0;
        }
        CDTimer += Time.deltaTime;
    }
   */
   
}
