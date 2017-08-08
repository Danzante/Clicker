using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float curHP, maxHP, curMana, maxMana, dmgMult, orgAttack, orgDeffend, orgMana, curDeffend, orgHeal, deffendMult, manaMult, healMult;
    MainCtrl opponent;


	// Update is called once per frame
	void Update () {
	}

    public void GetStrike(float dmg)
    {
        curHP -= dmg;
        curHP = Mathf.Min(curHP, maxHP);
        if(curHP < 0)
        {
            Die();
        }
    }

    void Die()
    {

    }

    public void Attack(float Clicks)
    {
        if (opponent != null) {
            opponent.GetStrike(Clicks * dmgMult);
        }
    }

    public void Deffend(float Clicks)
    {
        curDeffend += Clicks * deffendMult;
    }

    public void Heal(float Clicks)
    {
        GetStrike(-healMult * Clicks);
    }

    public void Mana(float Clicks)
    {
        curMana += manaMult * Clicks;
        curMana = Mathf.Min(curMana, maxMana);
    }
}
