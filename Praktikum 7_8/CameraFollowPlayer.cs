using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject CharacterRobotBoy;
    public float offsetXDist=2;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offsetXDist+=CharacterRobotBoy.transform.position.x;
        offset = transform.position - new Vector3(offsetXDist,
            CharacterRobotBoy.transform.position.y,
            CharacterRobotBoy.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = CharacterRobotBoy.transform.position + offset;
    }
}
