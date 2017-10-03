using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    // Player Move script is from Zachari John's Level 2 Ghost house Game // 
    public Vector3 Backup;
    public GameObject currentCheckpoint;
    public GameObject Startpoint;
    public GameObject Player;
    [SerializeField] // This will make the variable below appear in the inspector
    float speed = 10f;
    [SerializeField]
    float jumpSpeed = 10f;
    [SerializeField]
    float gravity = 50f;
    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;
    //bool isJumping; // "controller.isGrounded" can be used instead
    [SerializeField]
    int nrOfAlowedDJumps = 1; // New vairable
    int dJumpCounter = 0;     // New variable
    public Text winText;
    public Text BossText;
    public Text WeakAlert;
    public Text BossTaunt;
    public Text BossMad;
    public Text BossWut;
    public Text BosssadDefeat;
    public Text countText;
    private int count;
    public GameObject enimu1;
    public GameObject enimu2;
    public GameObject enimu3;
    public GameObject enimu4;
    public GameObject enimu5;
    public GameObject enimu6;
    public GameObject enimu7;
    public GameObject enimu8;
    public GameObject enimu9;
    public GameObject enimu10;
  
    // Use this for initialization
    void Start()
    {
        count = 0;
        SetCountText();
        controller = GetComponent<CharacterController>();
        winText.text = "";
        BossText.text = "";
        WeakAlert.text = "";
        BossMad.text = "";
        BosssadDefeat.text = "";
        BossWut.text = "";
        Backup = new Vector3(-20, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection.x = Input.GetAxis("Horizontal") * speed;
        moveDirection.z = Input.GetAxis("Vertical") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            if (controller.isGrounded)
            {
                moveDirection.y = jumpSpeed;
                dJumpCounter = 0;
            }
            if (!controller.isGrounded && dJumpCounter < nrOfAlowedDJumps)
            {
                gravity = 10;


            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);


    }
    //Enemy Tag from Zachari John's Level 2 Ghost House Game//
    //Player Checkpoint inspired by gamesplusjames//
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy2"))
        {
            Debug.Log("NOT LIKE THIS");
            Player.transform.position = currentCheckpoint.transform.position;
        }
        if (other.gameObject.CompareTag("Enemy1"))
        {
            Debug.Log("HOME SWEET HOME");
            Player.transform.position = Startpoint.transform.position;
        }
        if (other.gameObject.CompareTag("Cappy"))
        {
            Debug.Log("MY BABY");
            other.gameObject.SetActive(false);
            BosssadDefeat.text = "What a boxing match : n :";
            winText.text = "YAY YOU WIN!!";
            enimu1.gameObject.SetActive(false);
            enimu2.gameObject.SetActive(false);
            enimu3.gameObject.SetActive(false);
            enimu4.gameObject.SetActive(false);
            enimu5.gameObject.SetActive(false);
            enimu6.gameObject.SetActive(false);
            enimu7.gameObject.SetActive(false);
            enimu8.gameObject.SetActive(false);
            enimu10.gameObject.SetActive(false);
            WeakAlert.gameObject.SetActive(false);
            BossWut.gameObject.SetActive(false);
            BossTaunt.gameObject.SetActive(false);
            BossText.gameObject.SetActive(false);
            BossMad.gameObject.SetActive(false);
            
        }


        if (other.gameObject.CompareTag("Pickup")){

            Debug.Log("pie");
             other.gameObject.SetActive(false); 
              count = count + 1;
              SetCountText(); 
        }
     
        
    }
    void SetCountText() //Code provides from Zachari John's Ghost house Level 2
    {

        countText.text = "Count: " + count.ToString();
        if (count >= 0)
        {
            BossTaunt.text = "Mwahaha You will NEVER get your... thing.. back";
        }
        countText.text = "Count: " + count.ToString();
        if (count >= 2)
        {   
            enimu2.gameObject.SetActive(false);
        }
        countText.text = "Count: " + count.ToString();
        if (count >= 4)
        {
            BossTaunt.gameObject.SetActive(false);
            BossText.text = "Thats okay... They were ugly hencemen";
            enimu4.gameObject.SetActive(false);
            enimu1.gameObject.SetActive(false);
            enimu3.gameObject.SetActive(false);

        }
        countText.text = "Count: " + count.ToString();
        if (count >= 6)
        {
            BossMad.text = "Im starting to think Circles are better...";
            enimu6.gameObject.SetActive(false);
            enimu7.gameObject.SetActive(false);
            enimu5.gameObject.SetActive(false);
            BossText.gameObject.SetActive(false);
        }

        countText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            BossMad.gameObject.SetActive(false);
            BossWut.text = "= _ = ";
            WeakAlert.text = "Evil Box Man is weak by -3 points! Go Get EM!";
        }
    }
}

