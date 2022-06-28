using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Animator BullAnim;
    public Transform Player;
    [SerializeField] float longDistance, distanceToPlayer, closeDistance;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        BullAnim = GetComponent<Animator>();  //Get component animator of bull
    }

    // Update is called once per frame
    void Update()
    {
        DetectPlayer();
    }

    void DetectPlayer()  //Walk to player if player was standed in area and trigger walk animation
    {
        distanceToPlayer = Vector3.Distance(Player.position, transform.position);
        if (distanceToPlayer <= longDistance)
        {
            BullAnim.SetBool("isWalk", true);
            FollowPlayer();
        }
        else
        {
            BullAnim.SetBool("isWalk", false);
        }
    }

    void FollowPlayer()  //Move to player position
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
    }

    private void OnDrawGizmosSelected()  //Set area that trigger DetectPlayer code
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, longDistance);

        /*Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, closeDistance);*/
    }

}
