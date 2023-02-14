using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySM : MonoBehaviour
{
    //ref to distance thresholds when switching states
    private float setDistanceToPlayer = 30f;
    private float setDistanceToPointAB = 5f;
    //ref to patrol point locations
    public GameObject patrolPointA, patrolPointB, patrolPointC;
    private GameObject player;
    [SerializeField] private float patrolSpeed = 5f;
    [SerializeField] private float chaseSpeed = 8f;
    //enemy states 
    public enum EnemyStates { patrolToA, patrolToB, patrolToC, chase }
    public EnemyStates enemyStates = EnemyStates.patrolToA;


    // Start is called before the first frame update
    void Start()
    {
        //Assign player and patrol point refs
        player = GameObject.FindGameObjectWithTag("Player");
        patrolPointA = GameObject.FindGameObjectWithTag("PointA");
        patrolPointB = GameObject.FindGameObjectWithTag("PointB");
        patrolPointC = GameObject.FindGameObjectWithTag("PointC");
    }

    // Update is called once per frame
    void Update()
    {
  
        //debug distance checker
        //Debug.Log("Player is" + Vector3.Distance(player.transform.position, transform.position) + "from" + gameObject.name);
        //Debug.Log("Patrol Point A is" + Vector3.Distance(patrolPointA.transform.position, transform.position) + "from" + gameObject.name);
        //Debug.Log("Patrol Point B is" + Vector3.Distance(patrolPointB.transform.position, transform.position) + "from" + gameObject.name);
        //Debug.Log("Patrol Point C is" + Vector3.Distance(patrolPointC.transform.position, transform.position) + "from" + gameObject.name);

        switch (enemyStates)
        {
            case EnemyStates.patrolToA:
                
                // default state to patrol to point a
                transform.LookAt(patrolPointA.transform.position);
                transform.Translate(Vector3.forward * patrolSpeed * Time.deltaTime);

                //if distance to point a is less than... switch to point b
                if (Vector3.Distance(patrolPointA.transform.position, transform.position) < setDistanceToPointAB)
                {
                    enemyStates = EnemyStates.patrolToB;
                }
                
            //if player is less than... distance, set enemy state to chase.
            if(Vector3.Distance(player.transform.position, transform.position) < setDistanceToPlayer)
                {
                    //The player is close, set enemy state to chase
                    enemyStates = EnemyStates.chase;
                }
                break;

            case EnemyStates.patrolToB:
                
                transform.LookAt(patrolPointB.transform.position);
                transform.Translate(Vector3.forward * patrolSpeed * Time.deltaTime);

                //if distance to point b is less than... switch to point c
                if (Vector3.Distance(patrolPointB.transform.position, transform.position) < setDistanceToPointAB)
                {
                    enemyStates=EnemyStates.patrolToC;
                }

                //if player is less than... distance, set enemy state to chase.
                if (Vector3.Distance(player.transform.position, transform.position) < setDistanceToPlayer)
                {
                    //The player is close, set enemy state to chase
                    enemyStates = EnemyStates.chase;
                }
                break;

            case EnemyStates.patrolToC:

                transform.LookAt(patrolPointC.transform.position);
                transform.Translate(Vector3.forward * patrolSpeed * Time.deltaTime);

                //if distance to point c is less than... switch to point a
                if (Vector3.Distance(patrolPointC.transform.position, transform.position) < setDistanceToPointAB)
                {
                    enemyStates = EnemyStates.patrolToA;
                }

                //if player is less than... distance, set enemy state to chase.
                if (Vector3.Distance(player.transform.position, transform.position) < setDistanceToPlayer)
                {
                    //The player is close, set enemy state to chase
                    enemyStates = EnemyStates.chase;
                }
                break;

            case EnemyStates.chase:
                
                 //look at player
                 transform.LookAt(player.transform.position);

                 //move towards player          
                 transform.Translate(Vector3.forward * chaseSpeed * Time.deltaTime);
            
                 //if player is more than... distance, set enemy state to patrol.
                 if(Vector3.Distance(player.transform.position, transform.position) > 42f)
                 {
                     //The player is too far, set the enemy state to patrol
                     enemyStates = EnemyStates.patrolToA;
                 }
                  break;

            default:
                //if patrol or chase are both not true
                Debug.Log("Enemy state =" + enemyStates);
                break;
        }
    }
}
