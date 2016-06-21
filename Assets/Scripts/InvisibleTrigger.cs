using UnityEngine;


/// <summary>
/// 可见的陷阱
/// </summary>
public class InvisibleTrigger : MonoBehaviour
{
    public Color color = Color.white;

    private BoxCollider2D boxCollider = null;

    public BoxCollider2D BoxCollider
    {
        get
        {
            if (boxCollider == null)
            {
                boxCollider = GetComponent<BoxCollider2D>();
            }
            return boxCollider;
        }
    }

    private CircleCollider2D circleCollider = null;

    public CircleCollider2D CircleCollider
    {
        get
        {
            if (circleCollider == null)
            {
                circleCollider = GetComponent<CircleCollider2D>();
            }
            return circleCollider;
        }
    }


    /// <summary>
    /// 2D碰撞检测触发
    /// </summary>
    /// <param name="coll"></param>
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log(coll.gameObject.name + " entered " + gameObject.name);
    }

    void OnDrawGizmos()
    {
        DrawGizmo();
    }


    void OnDrawGizmosSelected()
    {
        DrawGizmo();
    }


    private void DrawGizmo()
    {
        Color oldColor = Gizmos.color;

        Gizmos.color = color;

        if (BoxCollider != null)
        {
            Gizmos.DrawWireCube(transform.position, new Vector3(BoxCollider.size.x, BoxCollider.size.y, 1.0f));
        }

        if (CircleCollider != null)
        {
            Gizmos.DrawWireSphere(transform.position, CircleCollider.radius);
        }

        Gizmos.color = oldColor;
    }
}
