using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadtreeNode : MonoBehaviour
{
    public Rect bounds;
    public List<GameObject> objects;
    public QuadtreeNode[] children;

    public QuadtreeNode(Rect bounds)
    {
        this.bounds = bounds;
        this.objects = new List<GameObject>();
        this.children = null;
    }

    // Split the current node into 4 children
    public void Split()
    {
        // Define values for x,y, width and height for new Rect
        float subWidth = bounds.width / 2f;
        float subHeight = bounds.height / 2f;
        float x = bounds.x;
        float y = bounds.y;
        // Assign each child node with a bound box that is one quater the size of the current node's bounding box.
        children = new QuadtreeNode[4]; 
        children[0] = new QuadtreeNode(new Rect(x + subWidth, y, subWidth, subHeight));
        children[1] = new QuadtreeNode(new Rect(x, y, subWidth, subHeight));
        children[2] = new QuadtreeNode(new Rect(x, y + subHeight, subWidth, subHeight));
        children[3] = new QuadtreeNode(new Rect(x + subWidth, y + subHeight, subWidth, subHeight));
    }
}
