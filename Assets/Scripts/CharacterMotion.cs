using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class CharacterMotion : MonoBehaviourPunCallbacks
{
    public Rigidbody2D rigid;
    Vector2 hareket;
   public  int hýz;
    public Animator animasyon;
    public Text isimalani;
    //public CharacterStats characterstatscript;
    PhotonView pw;
    // Start is called before the first frame update
    void Start()
    {
        //characterstatscript = GetComponent<CharacterStats>();
        hýz = 2;
        PhotonNetwork.ConnectUsingSettings();
        pw = GetComponent<PhotonView>();
    }
   
   
    

    // Update is called once per frame
    void Update()
    {
        
        if(pw.IsMine==true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                rigid.velocity = new Vector2(2, 0);
            }
            else if (Input.GetMouseButtonUp(0))
            {
                rigid.velocity = new Vector2(0, 0);
            }
            //rigid.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            isimalani.GetComponent<Text>().text= PlayerPrefs.GetString("Name");
        }


       /* if (rigid.velocity.x < 0 || rigid.velocity.x>0)
        {
            animasyon.SetBool("ýsRunned", true);
        }
        else
        {
            animasyon.SetBool("ýsRunned", false);
        }*/
    }
    /*public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject); 
        characterstatscript.can += 20;
        if (characterstatscript.can>100)
        {
            characterstatscript.can = 100;
        }

    }*/
}
