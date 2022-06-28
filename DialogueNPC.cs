using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNPC : MonoBehaviour
{
    [SerializeField] float longDistance, distanceToPlayer, closeDistance;
    public Transform Player;

    public GameObject Icon;
    public GameObject DialogueBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DetectPlayer();
    }

    void DetectPlayer()
    {
        distanceToPlayer = Vector3.Distance(Player.position, transform.position);
        if (distanceToPlayer <= longDistance)  //If player was standed in area, Dialogue logo will appear and let player press z to open dialogue window
        {
            Icon.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Z))
            {
                DialogueBox.SetActive(true);

            }
        }
        else
        {
            Icon.SetActive(false);
            DialogueBox.SetActive(false);
        }
    }

    private void OnDrawGizmosSelected()  //Set area that trigger DetectPlayer code
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, longDistance);

    }

}
