using System.Collections.Generic;
using BehaviourTree;


public class GuardBT : Tree
{
    public UnityEngine.Transform[] waypoints;
    public static float speed = 2f;
    protected override Node SetupTree()
    {
        Node root = new TaskPatrol(transform, waypoints);
        return root;
    }
}

//https://docs.google.com/document/d/18MBDCwuU6GghnlRZVGI9x8ay2w4q2fxXX4XwQxx91M4/edit
//https://github.com/HamieSAE/Handouts/blob/main/Week%204/Behavior%20Tree%20-%20Part%202/GuardBT.cs

