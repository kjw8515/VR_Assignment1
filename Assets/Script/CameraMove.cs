using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Gyroscope gyro;

    // 카메라에 부착하여 카메라의 회전 및 위치를 조정하는 Script
    void Start()
    {
        //Gyro의 사용 허용
        gyro = Input.gyro;
        gyro.enabled = true;
    }

    Quaternion GyroToUnity(Quaternion q) => new Quaternion(q.x, q.y, -q.z, -q.w);

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = GyroToUnity(gyro.attitude);
        Vector3 playerForward = transform.forward;
        playerForward.y = 0;
        playerTransform.forward = playerForward;
        //가속도 센서의 정확도가 너무 약하다.
        //cameraParent.position = transform.position - gyro.userAcceleration * Time.deltaTime*50f + new Vector3(0, Time.deltaTime/10,0);
        //Debug.Log(Time.deltaTime);
    }
}
