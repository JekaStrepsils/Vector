using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 directiton;
    float speed = 5f;

    void Start() {

        //directiton = goal.transform.position - this.transform.position;
        
        //this.transform.Translate(directiton);
    }

    private void LateUpdate() 
    {
        directiton = goal.transform.position - this.transform.position;
        this.transform.LookAt(goal.transform.position);
        if (directiton.magnitude > 2)
        {
            Vector3 velocity = directiton.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}
