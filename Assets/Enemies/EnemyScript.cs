using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void AttackPlayer()
    {
        print("Enemy is attacking player");
    }
    private void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.red;
        AttackPlayer();
    }
    private void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
