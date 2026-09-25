using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EnemyScript : MonoBehaviour
{
    public TextMeshProUGUI variable = new();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    protected void DebugText(string text)
    {
        GameObject obj = GameObject.Find("Text");
        if(obj != null)
        {
            obj.GetComponent<TextMeshPro>().SetText(text);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void AttackPlayer()
    {
        variable.text = "enemy is attacking player";
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
